public class ExportReceipt
{
    public int Id { get; set; }

    public DateTime ExportDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string? ReceiverName { get; set; }

    public ICollection<ExportReceiptDetail>? ExportReceiptDetails { get; set; }
}