using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [Required(ErrorMessage = "Tên không được để trống")]
    [StringLength(100)]
    public string CustomerName { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Order>? Orders { get; set; }
}