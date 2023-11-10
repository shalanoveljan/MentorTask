using MentorTemplate.DataAccessLayer;
using MentorTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorTemplate.Controllers
{
    public class TrainerController : Controller
    {
        private readonly AppDbContext _context;

        public TrainerController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Trainer> trainers=await _context.Trainers.
                Include(t=>t.Category).
                ToListAsync();
            return View(trainers);
        }
    }
}
