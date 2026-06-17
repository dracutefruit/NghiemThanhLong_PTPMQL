using System.ComponentModel.DataAnnotations;

public class Device
{
    public int Id { get; set; }

    [Required]
    public string DeviceCode { get; set; }

    [Required]
    public string DeviceName { get; set; }

    public int StockQuantity { get; set; }

    public string? Unit { get; set; }

    public string? Description { get; set; }

    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }

    public int DeviceCategoryId { get; set; }
    public DeviceCategory? DeviceCategory { get; set; }

    public ICollection<ImportReceiptDetail>? ImportReceiptDetails { get; set; }

    public ICollection<ExportReceiptDetail>? ExportReceiptDetails { get; set; }
}