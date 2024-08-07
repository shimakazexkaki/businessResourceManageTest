using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace 員工資料管理.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Attachment",
                table: "員工資料",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CustomBoolean1",
                table: "員工資料",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CustomBoolean2",
                table: "員工資料",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CustomBoolean3",
                table: "員工資料",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CustomDecimal1",
                table: "員工資料",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CustomDecimal2",
                table: "員工資料",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CustomDecimal3",
                table: "員工資料",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomString1",
                table: "員工資料",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomString2",
                table: "員工資料",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomString3",
                table: "員工資料",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtensionField",
                table: "員工資料",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "員工資料",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attachment",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "CustomBoolean1",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "CustomBoolean2",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "CustomBoolean3",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "CustomDecimal1",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "CustomDecimal2",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "CustomDecimal3",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "CustomString1",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "CustomString2",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "CustomString3",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "ExtensionField",
                table: "員工資料");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "員工資料");
        }
    }
}
