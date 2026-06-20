using System.ComponentModel.DataAnnotations;

public class Category
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? CategoryName { get; set; }

    public ICollection<Device>? Devices { get; set; }
}