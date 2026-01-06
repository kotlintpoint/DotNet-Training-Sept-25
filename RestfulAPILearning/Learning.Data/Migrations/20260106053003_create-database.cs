using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Learning.Data.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("2f780705-48ec-4a85-b532-679bac6730a0"), "Technology", "San Francisco", new DateTime(2026, 3, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Annual conference on emerging technologies.", "Tech Conference", "Moscone Center" },
                    { new Guid("38dc6d7f-e134-4fa6-a51c-687ff1227979"), "Art", "New York", new DateTime(2026, 5, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "Modern art exhibition featuring international artists.", "Art Exhibition", "Metropolitan Museum of Art" },
                    { new Guid("4a72c39b-f766-4373-9631-46852e2bcb54"), "Music", "New Orleans", new DateTime(2026, 4, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), "Live jazz performance by local artists.", "Jazz Concert", "French Quarter Theater" },
                    { new Guid("bfe1b882-d29e-41b8-a48d-85910c81dbd2"), "Outdoors", "Denver", new DateTime(2026, 2, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), "A scenic hike through the mountains.", "Hiking Trip", "Rocky Mountain National Park" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
