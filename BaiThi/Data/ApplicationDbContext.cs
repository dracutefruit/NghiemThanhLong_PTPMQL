using Microsoft.EntityFrameworkCore;
using BaiThi.Models;

namespace BaiThi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
    }
}
// dotnet aspnet-codegenerator controller -name PhongBanController -m PhongBan -dc ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
