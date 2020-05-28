using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JACUniversity.Models;

namespace JACUniversity.Pages.Enrollments
{
    public class CreateModel : PageModel
    {
        private readonly JACUniversity.Models.JACUniversityContext _context;

        public CreateModel(JACUniversity.Models.JACUniversityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseID"] = new SelectList(_context.Course, "CourseId", "Title");
        ViewData["StudentID"] = new SelectList(_context.Student, "Id", "FullName");
        
            return Page();
        }

        [BindProperty]
        public Enrollment Enrollment { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Enrollment.Add(Enrollment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}