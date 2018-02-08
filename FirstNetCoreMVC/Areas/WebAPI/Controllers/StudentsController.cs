using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessEntities.Context;
using BusinessEntities.Models.ContosoUniversity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrackableEntities.EF.Core;
using TrackableEntities.Common.Core;

namespace FirstNetCoreMVC.Areas.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly MovieContext _context;

        public StudentsController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public IActionResult GetById(int id)
        {
            var item = _context.Person.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        /// <summary>
        /// Create a Student
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///         "id": 1,
        ///         "enrollmentDate":"2010-09-01T00:00:00",
        ///         "enrollments":null,
        ///         "lastName":"Last Name",
        ///         "firstName":"First Name",
        ///         "Discriminator":"Student or Instructor",
        ///         "trackingState": "Tracking states"
        ///     }
        ///
        /// </remarks>
        /// <param name="student"></param>
        /// <returns></returns>
        /// <response code="201">Returns the newly-created item</response>
        /// <response code="400">If the item is null</response>            
        [HttpPost]
        [ProducesResponseType(typeof(Student), 201)]
        [ProducesResponseType(typeof(Student), 400)]
        public async Task<IActionResult> CreateUpdate([FromBody] Student student)
        {
            if (student == null) return BadRequest();

            _context.ApplyChanges(student);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetStudent", new { id = student.Id }, student);
        }

        /// <summary>
        /// Delete specific Student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var studentToDelete = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);

            if (studentToDelete == null)
            {
                return NotFound();
            }

            studentToDelete.TrackingState = TrackingState.Deleted;

            _context.ApplyChanges(studentToDelete);
            await _context.SaveChangesAsync();

            return new NoContentResult();
        }

        [HttpGet]
        public IEnumerable<Student> GetAllStudent()
        {
            return _context.Students.ToList();
        }
    }
}