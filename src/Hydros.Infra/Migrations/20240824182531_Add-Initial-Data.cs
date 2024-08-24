using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hydros.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CustomerType = table.Column<int>(type: "int", nullable: false),
                    Identification = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nim = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TaxPayerId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumberBackup = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsOwn = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedOnUtc", "CustomerType", "Email", "Identification", "IsOwn", "Name", "Nim", "PhoneNumber", "PhoneNumberBackup", "TaxPayerId", "UpdatedOnUtc" },
                values: new object[] { new Guid("768f581d-95cb-4f15-a3dc-0005ee296b47"), new DateTime(2024, 8, 24, 18, 25, 31, 23, DateTimeKind.Utc).AddTicks(3188), 0, "andreluizlima.adv@hotmail.com", "660152860", true, "André Luiz da Silva Lima", "92635377553", "73988167515", "", "", new DateTime(2024, 8, 24, 18, 25, 31, 23, DateTimeKind.Utc).AddTicks(3190) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
