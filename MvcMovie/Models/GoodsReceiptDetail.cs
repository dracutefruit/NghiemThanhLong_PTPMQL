public class GoodsReceiptDetail
{
    public int Id { get; set; }

    public int GoodsReceiptId { get; set; }
    public GoodsReceipt? GoodsReceipts { get; set; }

    public int DeviceId { get; set; }
    public Device? Device { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}