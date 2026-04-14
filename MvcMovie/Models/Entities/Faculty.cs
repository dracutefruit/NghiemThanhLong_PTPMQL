using System.ComponentModel.DataAnnotations;
using MvcMovie.Models.Entities;

namespace MvcMovie.Models.Entities
{
    public class Faculty
    {
        [Key]
        [Required(ErrorMessage = "Ma khoa khong duoc de trong")]
        public string? FacultyId { get; set; }
        [Required(ErrorMessage = "Ten khoa khong duoc de trong")]
        public string? FacultyName { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
    }
}