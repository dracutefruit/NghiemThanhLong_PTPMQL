using System.ComponentModel.DataAnnotations;

public class DeviceCategory
{
    public int Id { get; set; }

    [Required]
    public string CategoryName { get; set; }

    public string? Description { get; set; }

    public ICollection<Device>? Devices { get; set; }
}