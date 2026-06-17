using System.ComponentModel.DataAnnotations;

public class Supplier
{
    public int Id { get; set; }

    [Required]
    public string SupplierName { get; set; }

    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }

    public ICollection<Device>? Devices { get; set; }
    public ICollection<ImportReceipt>? ImportReceipts { get; set; }
}