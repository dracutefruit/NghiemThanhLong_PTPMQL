using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcMovie.Models.Entities;

namespace MvcMovie.Models.Entities;

    public class Student 
    {
    [Key]
    [MinLength(6,ErrorMessage = "Ma SV phai co it nhat 6 ky tu")]
    public required string StudentCode { get; set;}
    [Required(ErrorMessage = "Ten khong duoc de trong")]
    public required string FullName { get; set;}

    public string? FacultyId { get; set; }
    [ForeignKey("FacultyId")]
    public Faculty? Faculty {  get; set; }
    }