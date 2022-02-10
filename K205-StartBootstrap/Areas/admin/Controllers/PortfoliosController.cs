using K205Deneme.Areas.admin.ViewModel;
using K205Deneme.Data;
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

        public IActionResult Index()
        {
            
            AdminVM vm = new()
            {
                Portfolios = _context.Portfolios.ToList()
            };
            return View(vm);
        }
    }
}
