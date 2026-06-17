public class ImportReceiptDetail
{
    public int Id { get; set; }

    public int ImportReceiptId { get; set; }
    public ImportReceipt? ImportReceipt { get; set; }

    public int DeviceId { get; set; }
    public Device? Device { get; set; }

    public decimal ImportPrice { get; set; }

    public int Quantity { get; set; }

    public decimal Amount { get; set; }
}