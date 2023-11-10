using MentorTemplate.DataAccessLayer;
using MentorTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorTemplate.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;

        public CoursesController(AppDbContext context)
        {
          _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Course> courses=await _context.Courses
                .Include(c=>c.Trainer)
                .ThenInclude(t=>t.Category)
                .ToListAsync();
            return View(courses);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null){
                return BadRequest();
            }

            Course? course=await _context.Courses
                .Include(c=>c.Trainer)
                .Include(c=>c.Modules)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }
    }
}
