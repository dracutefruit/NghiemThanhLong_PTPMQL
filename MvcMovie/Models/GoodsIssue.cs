using System.ComponentModel.DataAnnotations;

public class GoodsIssue
{
    public int Id { get; set; }

    [Required]
    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }

    [Required]
    public string? IssueCode { get; set; }

    [Required]
    public DateTime IssueDate { get; set; }

    public ICollection<GoodsIssueDetail>? GoodsIssueDetails { get; set; }
    public ICollection<GoodsReceiptDetail>? GoodsReceiptDetails { get; set; }
}