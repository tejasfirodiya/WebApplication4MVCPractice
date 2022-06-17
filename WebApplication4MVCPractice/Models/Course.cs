using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4MVCPractice.Models;

[Table("Course", Schema="course")]
public class Course
{
    [Key]
    public int Course_Id { get; set; }
    public string Course_Code { get; set; }
    public string Course_Title { get; set; }
    public string Course_Description { get; set; }
}


