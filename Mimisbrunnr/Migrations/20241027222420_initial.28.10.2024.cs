using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mimisbrunnr.Migrations
{
    /// <inheritdoc />
    public partial class initial28102024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Name", "State", "StreetAddress" },
                values: new object[] { "Baku City", "CodersAz", "Absheron", "123 St" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name", "State", "StreetAddress" },
                values: new object[] { "Istanbul City", "Nadir Books", "Istanbul", "999 St" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StreetAddress",
                value: "99 St");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Name", "State", "StreetAddress" },
                values: new object[] { "Tech City", "Tech Solution", "IL", "123 Tech St" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name", "State", "StreetAddress" },
                values: new object[] { "Vid City", "Vivid Books", "IL", "999 Vid St" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StreetAddress",
                value: "999 Main St");
        }
    }
}
