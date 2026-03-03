using Microsoft.EntityFrameWorkCore;

namespace MvcMovie.Models.Entities;

public class Student {
    [Key]
    public string FullName { get; set;}
    public string StudentCode { get; set;}
}