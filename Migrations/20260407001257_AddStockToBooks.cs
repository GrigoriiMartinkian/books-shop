using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.Migrations
{
    /// <inheritdoc />
    public partial class AddStockToBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Stock",
                value: 6);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Genre", "ImageUrl", "Price", "Stock", "Title" },
                values: new object[,]
                {
                    { 6, "J.R.R. Tolkien", "A fantasy novel about the journey of Bilbo Baggins.", "Fantasy", "https://covers.openlibrary.org/b/id/8406786-L.jpg", 13m, 12, "The Hobbit" },
                    { 7, "F. Scott Fitzgerald", "A story of wealth, love and the American Dream.", "Classic", "https://covers.openlibrary.org/b/id/8432938-L.jpg", 8m, 7, "The Great Gatsby" },
                    { 8, "Frank Herbert", "An epic science fiction saga set in a desert world.", "Sci-Fi", "https://covers.openlibrary.org/b/id/8786077-L.jpg", 15m, 9, "Dune" },
                    { 9, "Paulo Coelho", "A philosophical novel about following your dreams.", "Fiction", "https://covers.openlibrary.org/b/id/8215523-L.jpg", 11m, 14, "The Alchemist" },
                    { 10, "Aldous Huxley", "A dystopian vision of a future controlled society.", "Dystopia", "https://covers.openlibrary.org/b/id/8739166-L.jpg", 10m, 6, "Brave New World" },
                    { 11, "Andrew Hunt", "Essential advice for software developers.", "Programming", "https://covers.openlibrary.org/b/id/8576066-L.jpg", 25m, 4, "The Pragmatic Programmer" },
                    { 12, "Harper Lee", "A story of racial injustice and moral growth.", "Classic", "https://covers.openlibrary.org/b/id/8576067-L.jpg", 9m, 11, "To Kill a Mockingbird" },
                    { 13, "J.R.R. Tolkien", "An epic quest to destroy the One Ring.", "Fantasy", "https://covers.openlibrary.org/b/id/8406787-L.jpg", 20m, 8, "The Lord of the Rings" },
                    { 14, "Ray Bradbury", "A world where books are banned and burned.", "Dystopia", "https://covers.openlibrary.org/b/id/8739167-L.jpg", 9m, 7, "Fahrenheit 451" },
                    { 15, "Douglas Adams", "A hilarious sci-fi comedy about the end of the world.", "Sci-Fi", "https://covers.openlibrary.org/b/id/8576068-L.jpg", 11m, 10, "The Hitchhiker Guide to the Galaxy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Books");
        }
    }
}
