using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models.Entities;

    [Table("Student")]

    public class Student 
    {
    [Key]
    public string FullName { get; set;}
    public string StudentCode { get; set;}
    }