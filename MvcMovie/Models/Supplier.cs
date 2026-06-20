using System.ComponentModel.DataAnnotations;

public class Supplier
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? SupplierName { get; set; }

    public ICollection<GoodsReceipt>? GoodsReceipts { get; set; }
    public ICollection<GoodsReceiptDetail>? GoodsReceiptDetails { get; set; }
    public ICollection<GoodsIssueDetail>? GoodsIssueDetails { get; set; }
}