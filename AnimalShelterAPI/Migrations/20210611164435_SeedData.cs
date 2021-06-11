using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 4, "Lovely", "Male", "Doug" },
                    { 2, 2, "Lovely", "Male", "Bruce" },
                    { 3, 5, "Lovely", "Male", "Steve" },
                    { 4, 9, "Lovely", "Female", "Carla" },
                    { 5, 18, "Lovely", "Female", "Betty" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Description", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 4, "Lovely", "Male", "Mike" },
                    { 2, 2, "Lovely", "Male", "Dave" },
                    { 3, 5, "Lovely", "Male", "Buster" },
                    { 4, 9, "Lovely", "Female", "Penelope" },
                    { 5, 18, "Lovely", "Female", "Emma" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);
        }
    }
}
