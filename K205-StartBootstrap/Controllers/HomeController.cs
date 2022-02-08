using System.Diagnostics;
using K205Deneme.Models;
using Microsoft.AspNetCore.Mvc;
using K205Deneme.Data;
using K205Deneme.ViewModel;
using Microsoft.EntityFrameworkCore;


namespace K205Deneme.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DenemeDbContext _context;

        public HomeController(ILogger<HomeController> logger, DenemeDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                Masthead = _context.Mastheads.FirstOrDefault(),
                Abouts = _context.Abouts.ToList(),
                Portfolios = _context.Portfolios.ToList()

            };

            return View(homeVM);
        }



        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}