using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace 員工資料管理.Migrations
{
    /// <inheritdoc />
    public partial class Last4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "聯絡人電話",
                table: "員工資料",
                newName: "連絡人電話");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "連絡人電話",
                table: "員工資料",
                newName: "聯絡人電話");
        }
    }
}
