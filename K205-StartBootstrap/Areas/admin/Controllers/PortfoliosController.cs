using K205Deneme.Areas.admin.ViewModel;
using K205Deneme.Data;
using K205Deneme.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace K205Deneme.Areas.admin.Controllers
{
    [Area("admin")]
    public class PortfoliosController : Controller
    {
        private readonly DenemeDbContext _context;

        public PortfoliosController(DenemeDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Portfolios.ToListAsync());
        }

        public async Task<IActionResult> Detail(int id)
        {
            var portfolio = _context.Portfolios.FirstOrDefault(x => x.Id == id);
            if (portfolio == null) return NotFound();
            return View(portfolio);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Portfolio portfolio)
        {
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction(nameof(Create));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var portfolio = _context.Portfolios.FirstOrDefault(x => x.Id == id);
            if (portfolio == null) return NotFound();
            return View(portfolio);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Portfolio portfolio)
        {
            try
            {
                _context.Entry(portfolio);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return NotFound();
            }



            return View();
        }
    }
}
