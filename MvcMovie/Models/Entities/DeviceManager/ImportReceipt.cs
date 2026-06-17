public class ImportReceipt
{
    public int Id { get; set; }

    public DateTime ImportDate { get; set; }

    public decimal TotalAmount { get; set; }

    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }

    public ICollection<ImportReceiptDetail>? ImportReceiptDetails { get; set; }
}