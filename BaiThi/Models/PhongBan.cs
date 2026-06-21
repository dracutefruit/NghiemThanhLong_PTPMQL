using System.ComponentModel.DataAnnotations;

public class PhongBan
{
    [Key]
    public string MaPhongBan { get; set; }
    public string TenPhongBan { get; set; }
    public ICollection<NhanVien>? NhanViens { get; set; }
}