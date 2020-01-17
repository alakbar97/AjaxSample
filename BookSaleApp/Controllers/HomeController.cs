using BookSaleApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookSaleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BookDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> GetAllAuthors()
        {
            return Json(await _context.Authors.ToListAsync());

        }
        [HttpPost]
        public async Task<IActionResult> GetBooksByAuthor(int id)
        {
            return Json(await _context.AuthorBooks.
                                    Where(x => x.AuthorId == id).
                                                    Select(x => new { x.Book.Id, x.Book.Name }).
                                                                ToListAsync());
        }

        [HttpPost]

        public async Task<IActionResult> GetLangByBookId(int id)
        {
            return Json(await _context.BookLanguages.
                                        Where(x => x.BookId == id).
                                                    Select(x => new { x.Language.Name }).
                                                                   ToListAsync());


        }

        public IActionResult Index()
        {
            return View();
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
