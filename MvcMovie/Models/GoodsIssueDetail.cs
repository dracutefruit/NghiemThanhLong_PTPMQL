public class GoodsIssueDetail
{
    public int Id { get; set; }

    public int GoodsIssueId { get; set; }
    public GoodsIssue? GoodsIssue { get; set; }

    public int DeviceId { get; set; }
    public Device? Device { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}