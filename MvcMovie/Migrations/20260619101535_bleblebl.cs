using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class bleblebl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsReceiptDetails_Suppliers_SupplierId",
                table: "GoodsReceiptDetails");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "GoodsReceiptDetails",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsReceiptDetails_Suppliers_SupplierId",
                table: "GoodsReceiptDetails",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsReceiptDetails_Suppliers_SupplierId",
                table: "GoodsReceiptDetails");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "GoodsReceiptDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsReceiptDetails_Suppliers_SupplierId",
                table: "GoodsReceiptDetails",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
