using Microsoft.EntityFrameworkCore;
using MvcMovie.Models.Entities;

namespace MvcMovie.Data
{
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {}
    public DbSet<Student> Students { get; set; }
    public DbSet<Faculty> Faculties { get; set; }

    //Buoi9
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    //Buoi12
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<DeviceCategory> DeviceCategories { get; set; }
    public DbSet<Device> Devices { get; set; }
    public DbSet<ImportReceipt> ImportReceipts { get; set; }
    public DbSet<ImportReceiptDetail> ImportReceiptDetails { get; set; }
    public DbSet<ExportReceipt> ExportReceipts { get; set; }
    public DbSet<ExportReceiptDetail> ExportReceiptDetails { get; set; }
}
}