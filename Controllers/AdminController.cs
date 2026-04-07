using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly AppDbContext _db;

        public AdminController(AppDbContext db)
        {
            _db = db;
        }

        // GET /Admin — список всех книг
        public async Task<IActionResult> Index()
        {
            var books = await _db.Books.ToListAsync();
            return View(books);
        }

        // GET /Admin/Create — форма создания книги
        public IActionResult Create()
        {
            return View();
        }

        // POST /Admin/Create
        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (!ModelState.IsValid) return View(book);
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            TempData["Message"] = "Book added successfully!";
            return RedirectToAction("Index");
        }

        // GET /Admin/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var book = await _db.Books.FindAsync(id);
            if (book == null) return NotFound();
            return View(book);
        }

        // POST /Admin/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            if (!ModelState.IsValid) return View(book);
            _db.Books.Update(book);
            await _db.SaveChangesAsync();
            TempData["Message"] = "Book updated successfully!";
            return RedirectToAction("Index");
        }

        // POST /Admin/Delete
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _db.Books.FindAsync(id);
            if (book != null)
            {
                _db.Books.Remove(book);
                await _db.SaveChangesAsync();
            }
            TempData["Message"] = "Book deleted.";
            return RedirectToAction("Index");
        }

        // POST /Admin/UpdateStock
        [HttpPost]
        public async Task<IActionResult> UpdateStock(int id, int stock)
        {
            var book = await _db.Books.FindAsync(id);
            if (book != null)
            {
                book.Stock = stock;
                await _db.SaveChangesAsync();
                TempData["Message"] = $"Stock updated for \"{book.Title}\".";
            }
            return RedirectToAction("Index");
        }
    }
}