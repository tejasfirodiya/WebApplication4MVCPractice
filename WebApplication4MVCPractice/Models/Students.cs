using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4MVCPractice.Models;

[Table("Student", Schema ="student")]
public class Students
{
    [Key]
    public int Student_Id { get; set; }
    public int Student_Roll_No { get; set; }
    public string Student_Name { get; set; }
    public string Student_email { get; set; }
    public string Student_Address { get; set; }
    public int FK_Course_Id { get; set; }
    [ForeignKey(nameof(FK_Course_Id))]
    public Course course { get; set;}
}
