using BookShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _db;

        public BooksController(AppDbContext db)
        {
            _db = db;
        }

        // GET /Books — каталог книг с поиском и фильтром
        public async Task<IActionResult> Index(string? search, string? genre)
        {
            // Get all books from DB
            var books = _db.Books.AsQueryable();

            // Filter by title or author
            if (!string.IsNullOrEmpty(search))
                books = books.Where(b =>
                    b.Title.Contains(search) || b.Author.Contains(search));

            // Фильтр по жанру
            if (!string.IsNullOrEmpty(genre))
                books = books.Where(b => b.Genre == genre);

            // Pass genre list for the dropdown
            ViewBag.Genres = await _db.Books
                .Select(b => b.Genre)
                .Distinct()
                .ToListAsync();

            ViewBag.Search = search;
            ViewBag.Genre = genre;

            return View(await books.ToListAsync());
        }

        // GET /Books/Details/5 — подробная страница книги
        public async Task<IActionResult> Details(int id)
        {
            var book = await _db.Books.FindAsync(id);
            if (book == null) return NotFound();
            return View(book);
        }
    }
}
