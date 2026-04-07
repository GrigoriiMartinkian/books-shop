using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookShop.Models;

namespace BookShop.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<CartItem> CartItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
      new Book { Id = 1, Title = "The Master and Margarita", Author = "Mikhail Bulgakov", Price = 12, Genre = "Classic", Stock = 10, Description = "A novel about good and evil, love and betrayal.", ImageUrl = "photo/TheMasterandMargarita.jpg" },
      new Book { Id = 2, Title = "1984", Author = "George Orwell", Price = 10, Genre = "Dystopia", Stock = 8, Description = "A classic of the dystopian genre.", ImageUrl = "photo/1984.jpg" },
      new Book { Id = 3, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Price = 9, Genre = "Classic", Stock = 5, Description = "A psychological novel about moral choice.", ImageUrl = "photo/CrimeandPunishment.jpg" },
      new Book { Id = 4, Title = "Harry Potter and the Philosopher Stone", Author = "J.K. Rowling", Price = 14, Genre = "Fantasy", Stock = 15, Description = "The first book about a young wizard.", ImageUrl = "photo/HarryPotter.jpg" },
      new Book { Id = 5, Title = "Clean Code", Author = "Robert Martin", Price = 22, Genre = "Programming", Stock = 6, Description = "A guide to writing good clean code.", ImageUrl = "photo/CleanCode.jpg" },
      new Book { Id = 6, Title = "The Hobbit", Author = "J.R.R. Tolkien", Price = 13, Genre = "Fantasy", Stock = 12, Description = "A fantasy novel about the journey of Bilbo Baggins.", ImageUrl = "photo/TheHobbit.jpg" },
      new Book { Id = 7, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 8, Genre = "Classic", Stock = 7, Description = "A story of wealth, love and the American Dream.", ImageUrl = "photo/TheGreatGatsby.jpg" },
      new Book { Id = 8, Title = "Dune", Author = "Frank Herbert", Price = 15, Genre = "Sci-Fi", Stock = 9, Description = "An epic science fiction saga set in a desert world.", ImageUrl = "photo/Dune.jpg" },
      new Book { Id = 9, Title = "The Alchemist", Author = "Paulo Coelho", Price = 11, Genre = "Fiction", Stock = 14, Description = "A philosophical novel about following your dreams.", ImageUrl = "photo/TheAlchemist.jpg" },
      new Book { Id = 10, Title = "Brave New World", Author = "Aldous Huxley", Price = 10, Genre = "Dystopia", Stock = 6, Description = "A dystopian vision of a future controlled society.", ImageUrl = "photo/BraveNewWorld.jpg" },
      new Book { Id = 11, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Price = 25, Genre = "Programming", Stock = 4, Description = "Essential advice for software developers.", ImageUrl = "photo/ThePragmaticProgrammer.jpg" },
      new Book { Id = 12, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 9, Genre = "Classic", Stock = 11, Description = "A story of racial injustice and moral growth.", ImageUrl = "photo/ToKillaMockingbird.jpg" },
      new Book { Id = 13, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Price = 20, Genre = "Fantasy", Stock = 8, Description = "An epic quest to destroy the One Ring.", ImageUrl = "photo/TheLordoftheRings.jpg" },
      new Book { Id = 14, Title = "Fahrenheit 451", Author = "Ray Bradbury", Price = 9, Genre = "Dystopia", Stock = 7, Description = "A world where books are banned and burned.", ImageUrl = "photo/Fahrenheit451.jpg" },
      new Book { Id = 15, Title = "The Hitchhiker Guide to the Galaxy", Author = "Douglas Adams", Price = 11, Genre = "Sci-Fi", Stock = 10, Description = "A hilarious sci-fi comedy about the end of the world.", ImageUrl = "photo/TheHitchhikerGuidetotheGalaxy.jpg" }
  );
        }
    }
}