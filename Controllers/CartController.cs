using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public CartController(AppDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        // GET /Cart
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var items = await _db.CartItems
                .Include(c => c.Book)
                .Where(c => c.UserId == userId)
                .ToListAsync();
            return View(items);
        }

        // POST /Cart/Add
        [HttpPost]
        public async Task<IActionResult> Add(int bookId, int quantity = 1)
        {
            var userId = _userManager.GetUserId(User);
            var book = await _db.Books.FindAsync(bookId);

            if (book == null)
            {
                TempData["Error"] = "Book not found.";
                return RedirectToAction("Index", "Books");
            }

            // Check stock availability
            var existing = await _db.CartItems
                .FirstOrDefaultAsync(c => c.BookId == bookId && c.UserId == userId);

            int alreadyInCart = existing?.Quantity ?? 0;
            int requested = alreadyInCart + quantity;

            if (requested > book.Stock)
            {
                TempData["Error"] = $"Sorry, only {book.Stock} copies of \"{book.Title}\" available. You already have {alreadyInCart} in your cart.";
                return RedirectToAction("Index", "Books");
            }

            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _db.CartItems.Add(new CartItem
                {
                    BookId = bookId,
                    UserId = userId!,
                    Quantity = quantity
                });
            }

            await _db.SaveChangesAsync();
            TempData["Message"] = $"\"{book.Title}\" added to cart!";
            return RedirectToAction("Index", "Books");
        }

        // POST /Cart/Remove
        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            var item = await _db.CartItems.FindAsync(id);
            if (item != null)
            {
                _db.CartItems.Remove(item);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        // POST /Cart/UpdateQuantity
        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int id, int quantity)
        {
            var item = await _db.CartItems
                .Include(c => c.Book)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (item == null) return RedirectToAction("Index");

            if (quantity <= 0)
            {
                _db.CartItems.Remove(item);
            }
            else if (quantity > item.Book!.Stock)
            {
                TempData["Error"] = $"Only {item.Book.Stock} copies available.";
            }
            else
            {
                item.Quantity = quantity;
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // POST /Cart/Buy
        [HttpPost]
        public async Task<IActionResult> Buy()
        {
            var userId = _userManager.GetUserId(User);
            var items = await _db.CartItems
                .Include(c => c.Book)
                .Where(c => c.UserId == userId)
                .ToListAsync();

            // Check stock for all items before buying
            foreach (var item in items)
            {
                if (item.Book!.Stock < item.Quantity)
                {
                    TempData["Error"] = $"Sorry, only {item.Book.Stock} copies of \"{item.Book.Title}\" available, but you have {item.Quantity} in cart.";
                    return RedirectToAction("Index");
                }
            }

            // Reduce stock for each book
            foreach (var item in items)
            {
                item.Book!.Stock -= item.Quantity;
            }

            _db.CartItems.RemoveRange(items);
            await _db.SaveChangesAsync();

            TempData["Message"] = "Order placed! Thank you for your purchase.";
            return RedirectToAction("Index", "Home");
        }
    }
}