using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FirstNetCoreMVC.ViewModels;
using Microsoft.EntityFrameworkCore;
using TrackableEntities.Common.Core;
using TrackableEntities.EF.Core;
using BusinessEntities.Context;
using BusinessEntities.Models.ContosoUniversity;

namespace FirstNetCoreMVC.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class InstructorsController : Controller
    {
        private readonly MovieContext _context;

        public InstructorsController(MovieContext context)
        {
            _context = context;
        }

        // GET: Instructors
        public async Task<IActionResult> Index(int? id, int? courseID)
        {
            InstructorViewModel viewModel = new InstructorViewModel();

            viewModel.Instructors = await _context.Instructors
                              .Include(i => i.OfficeAssignment)
                              .Include(i => i.CourseAssignments)
                                    .ThenInclude(i => i.Course)
                                        .ThenInclude(i => i.Enrollments)
                                            .ThenInclude(i => i.Student)
                              .Include(i => i.CourseAssignments)
                                    .ThenInclude(i => i.Course)
                                        .ThenInclude(i => i.Department)
                              .AsNoTracking()
                              .OrderBy(i => i.LastName)
                              .ToListAsync();

            if (id.HasValue)
            {
                ViewData["InstructorID"] = id.Value;
                Instructor instructor = viewModel.Instructors.FirstOrDefault(
                    i => i.Id == id.Value);
                viewModel.Courses = instructor.CourseAssignments.Select(s => s.Course).ToList();
            }

            if (courseID.HasValue)
            {
                ViewData["CourseID"] = courseID.Value;
                viewModel.Enrollments = viewModel.Courses.FirstOrDefault(
                    x => x.CourseId == courseID).Enrollments.ToList();
            }

            return View(viewModel);
        }

        // GET: Instructors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors
                .SingleOrDefaultAsync(m => m.Id == id);
            if (instructor == null)
            {
                return NotFound();
            }

            return View(instructor);
        }

        // GET: Instructors/Create
        public IActionResult Create()
        {
            var instructor = new Instructor();
            //instructor.CourseAssignments = new List<CourseAssignment>();
            PopulateAssignedCourseData(instructor);
            return View();
        }

        // POST: Instructors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Instructor instructor, string[] selectedCourses)
        {
            if (selectedCourses != null)
            {
                //instructor.CourseAssignments = new List<CourseAssignment>();
                foreach (var course in selectedCourses)
                {
                    var courseToAdd = new CourseAssignment { InstructorId = instructor.Id, CourseId = int.Parse(course) };
                    instructor.CourseAssignments.Add(courseToAdd);
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(instructor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            PopulateAssignedCourseData(instructor);
            return View(instructor);
        }

        // GET: Instructors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors
                .Include(x => x.OfficeAssignment)
                .Include(x => x.CourseAssignments)
                    .ThenInclude(x => x.Course)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.Id == id);

            if (instructor == null)
            {
                return NotFound();
            }
            PopulateAssignedCourseData(instructor);
            return View(instructor);
        }

        private void PopulateAssignedCourseData(Instructor instructor)
        {
            var allCourses = _context.Courses;
            var instructorCourses = new HashSet<int>(instructor.CourseAssignments.Select(x => x.CourseId));
            var viewModel = new List<AssignedCourseViewModel>();
            foreach (var course in allCourses)
            {
                viewModel.Add(new AssignedCourseViewModel()
                {
                    CourseID = course.CourseId,
                    Title = course.Title,
                    Assigned = instructorCourses.Contains(course.CourseId)
                });
            }
            ViewData["Courses"] = viewModel;
        }

        // POST: Instructors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Instructor instructor, string[] selectedCourses)
        {
            if (id != instructor.Id)
            {
                return NotFound();
            }

            var instructorToUpdate = await _context.Instructors
                .Include(i => i.OfficeAssignment)
                .Include(i => i.CourseAssignments)
                    .ThenInclude(i => i.Course)
                .SingleOrDefaultAsync(m => m.Id == id);

            if (await TryUpdateModelAsync(instructorToUpdate))
            {
                if (ModelState.IsValid)
                {
                    if (String.IsNullOrWhiteSpace(instructorToUpdate.OfficeAssignment?.Location))
                    {
                        instructorToUpdate.OfficeAssignment = null;
                    }
                    UpdateInstructorCourses(selectedCourses, instructorToUpdate);

                    try
                    {
                        //_context.ApplyChanges(instructor);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateException ex /* ex */)
                    {
                        //Log the error (uncomment ex variable name and write a log.)
                        ModelState.AddModelError("", "Unable to save changes. " +
                            "Try again, and if the problem persists, " +
                            "see your system administrator.");
                    }
                    return RedirectToAction(nameof(Index));
                }
            }

            //await _context.LoadRelatedEntitiesAsync(instructorToUpdate);

            UpdateInstructorCourses(selectedCourses, instructorToUpdate);
            PopulateAssignedCourseData(instructorToUpdate);
            return View(instructorToUpdate);
        }

        private void UpdateInstructorCourses(string[] selectedCourses, Instructor instructor)
        {
            if (selectedCourses == null)
            {
                //instructor.CourseAssignments = new List<CourseAssignment>();
                return;
            }
            var selectedCoursesHS = new HashSet<string>(selectedCourses);
            var instructorCourses = new HashSet<int>(instructor.CourseAssignments.Select(x => x.CourseId));
            foreach (var course in _context.Courses)
            {
                if (selectedCoursesHS.Contains(course.CourseId.ToString()))
                {
                    if (!instructorCourses.Contains(course.CourseId))
                    {
                        instructor.CourseAssignments.Add(new CourseAssignment { InstructorId = instructor.Id, CourseId = course.CourseId });
                    }
                }
                else
                {
                    if (instructorCourses.Contains(course.CourseId))
                    {
                        CourseAssignment courseToRemove = instructor.CourseAssignments.SingleOrDefault(i => i.CourseId == course.CourseId);
                        _context.Remove(courseToRemove);
                    }
                }
            }
        }

        // GET: Instructors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors
                .SingleOrDefaultAsync(m => m.Id == id);
            if (instructor == null)
            {
                return NotFound();
            }

            return View(instructor);
        }

        // POST: Instructors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Instructor instructor = await _context.Instructors
                .Include(i => i.CourseAssignments)
                .SingleAsync(i => i.Id == id);
            _context.Instructors.Remove(instructor);

            var departments = await _context.Departments
                .Where(d => d.InstructorId == id)
                .ToListAsync();

            departments.ForEach(d => d.InstructorId = null);

            _context.Instructors.Remove(instructor);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstructorExists(int id)
        {
            return _context.Instructors.Any(e => e.Id == id);
        }
    }
}
