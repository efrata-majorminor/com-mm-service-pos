using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.MM.Service.Pos.Lib.Migrations
{
    public partial class Delete_Column_in_Discount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoreCode",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Discounts");

            migrationBuilder.AddColumn<string>(
                name: "UId",
                table: "Discounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UId",
                table: "DiscountItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "UId",
                table: "DiscountItems");

            migrationBuilder.AddColumn<string>(
                name: "StoreCode",
                table: "Discounts",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Discounts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
