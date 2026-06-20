using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class zoaooassoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsIssueDetails_Suppliers_SupplierId",
                table: "GoodsIssueDetails");

            migrationBuilder.AlterColumn<string>(
                name: "IssueCode",
                table: "GoodsIssues",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "GoodsIssues",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "GoodsIssueDetails",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "GoodsIssueDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GoodsIssues_SupplierId",
                table: "GoodsIssues",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsIssueDetails_Suppliers_SupplierId",
                table: "GoodsIssueDetails",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsIssues_Suppliers_SupplierId",
                table: "GoodsIssues",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsIssueDetails_Suppliers_SupplierId",
                table: "GoodsIssueDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsIssues_Suppliers_SupplierId",
                table: "GoodsIssues");

            migrationBuilder.DropIndex(
                name: "IX_GoodsIssues_SupplierId",
                table: "GoodsIssues");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "GoodsIssues");

            migrationBuilder.AlterColumn<int>(
                name: "IssueCode",
                table: "GoodsIssues",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "GoodsIssueDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                table: "GoodsIssueDetails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsIssueDetails_Suppliers_SupplierId",
                table: "GoodsIssueDetails",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
