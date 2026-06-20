using System.ComponentModel.DataAnnotations;

public class GoodsReceipt
{
    public int Id { get; set; }

    [Required]
    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }

    [Required]
    public string? ReceiptCode { get; set; }

    [Required]
    public DateTime ReceiptDate { get; set; }

    public ICollection<GoodsReceiptDetail>? GoodsReceiptDetails { get; set; }
    public ICollection<GoodsIssueDetail>? GoodsIssueDetails { get; set; }
}