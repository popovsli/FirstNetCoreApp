﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessEntities.Models;
using BusinessEntities.Context;

namespace FirstNetCoreApp.Pages.Schedules
{
    public class DeleteModel : PageModel
    {

        private readonly MovieContext _context;

        public DeleteModel(MovieContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Schedule Schedule { get;  set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Schedule = await _context.Schedule.SingleOrDefaultAsync(x => x.ID == id);

            if(Schedule == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Schedule = await _context.Schedule.FindAsync(id);

            if(Schedule != null)
            {
                _context.Schedule.Remove(Schedule);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}