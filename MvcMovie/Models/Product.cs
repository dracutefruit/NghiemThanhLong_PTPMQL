using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [StringLength(150)]
    public string ProductName { get; set; } = null!;

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Giá phải >= 0")]
    public decimal Price { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "Tồn kho phải >= 0")]
    public int Stock { get; set; }

    public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
}