namespace BookShop.Models
{
    // Cart item — links a user and a book
    public class CartItem
    {
        public int Id { get; set; }

        // Book ID (foreign key)
        public int BookId { get; set; }
        public Book? Book { get; set; }

        // User ID from ASP.NET Identity
        public string UserId { get; set; } = "";

        // Quantity
        public int Quantity { get; set; } = 1;
    }
}
