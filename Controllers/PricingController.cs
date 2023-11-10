using MentorTemplate.DataAccessLayer;
using MentorTemplate.Models;
using MentorTemplate.ViewModels.PricingVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorTemplate.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Pricing> pricings = await _context.Pricings
                .Include(p => p.PricingServices)
                .ThenInclude(ps => ps.Service)
                .ToListAsync();


            //IndexVM viewModel = new IndexVM
            //{
            //    _pricings = pricings,
            //    pricingservices = _context.PricingServices.ToList()
            //};

            IndexVM viewModel=new IndexVM();
            viewModel._pricings = await _context.Pricings
                .Include(p => p.PricingServices)
                .ThenInclude(ps => ps.Service)
                .ToListAsync();
            viewModel.services=await _context.Services.ToListAsync();


            

            return View(viewModel);
        }
    }
}
