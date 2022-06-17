using WebApplication4MVCPractice.DataAccess;

namespace WebApplication4MVCPractice.Models.Services;

public class CourseService
{
    public List<Course> GetAll()
    {
        using var _context = new ApplicationDBContext();

        var course = _context.Course.ToList();

        return course;
    }
}
