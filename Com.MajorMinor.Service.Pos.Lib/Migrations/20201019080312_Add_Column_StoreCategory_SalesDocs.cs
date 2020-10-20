using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.MM.Service.Pos.Lib.Migrations
{
    public partial class Add_Column_StoreCategory_SalesDocs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StoreCategory",
                table: "SalesDocs",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoreCategory",
                table: "SalesDocs");
        }
    }
}
