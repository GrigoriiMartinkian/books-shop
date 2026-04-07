using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Migrations
{
    /// <inheritdoc />
    public partial class ChangePhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "photo/TheMasterandMargarita.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "photo/1984.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "photo/CrimeandPunishment.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "photo/HarryPotter.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "photo/CleanCode.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "photo/TheHobbit.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "photo/TheGreatGatsby.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "photo/Dune.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "photo/TheAlchemist.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "photo/BraveNewWorld.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "photo/ThePragmaticProgrammer.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "photo/ToKillaMockingbird.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "photo/TheLordoftheRings.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "photo/Fahrenheit451.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "photo/TheHitchhikerGuidetotheGalaxy.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8739161-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8575708-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8739161-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8234665-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8576065-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8406786-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8432938-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8786077-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8215523-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8739166-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8576066-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8576067-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8406787-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8739167-L.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://covers.openlibrary.org/b/id/8576068-L.jpg");
        }
    }
}
