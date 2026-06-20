using System.ComponentModel.DataAnnotations;

public class Device
{
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string DeviceName { get; set; } = default!;

    [Required]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Price must cannot be negative.")]
    public decimal Price { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Stock quantity cannot be negative.")]
    public int Stock { get; set; }

    public ICollection<GoodsReceiptDetail>? GoodsReceiptDetails { get; set; }
    public ICollection<GoodsIssueDetail>? GoodsIssueDetails { get; set; }
}