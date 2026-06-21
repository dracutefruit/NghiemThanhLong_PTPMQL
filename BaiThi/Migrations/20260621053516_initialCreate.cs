using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiThi.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    MaPhongBan = table.Column<string>(type: "TEXT", nullable: false),
                    TenPhongBan = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.MaPhongBan);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "TEXT", nullable: false),
                    TenNhanVien = table.Column<string>(type: "TEXT", nullable: false),
                    MaPhongBan = table.Column<string>(type: "TEXT", nullable: false),
                    PhongBanMaPhongBan = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_PhongBans_PhongBanMaPhongBan",
                        column: x => x.PhongBanMaPhongBan,
                        principalTable: "PhongBans",
                        principalColumn: "MaPhongBan");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_PhongBanMaPhongBan",
                table: "NhanViens",
                column: "PhongBanMaPhongBan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
