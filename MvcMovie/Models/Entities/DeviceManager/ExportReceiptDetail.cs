public class ExportReceiptDetail
{
    public int Id { get; set; }

    public int ExportReceiptId { get; set; }
    public ExportReceipt? ExportReceipt { get; set; }

    public int DeviceId { get; set; }
    public Device? Device { get; set; }

    public decimal ExportPrice { get; set; }

    public int Quantity { get; set; }

    public decimal Amount { get; set; }
}