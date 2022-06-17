using Microsoft.AspNetCore.Mvc;
using WebApplication4MVCPractice.DataAccess;

namespace WebApplication4MVCPractice.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var context = new ApplicationDBContext();

            return View( context.student.ToList());
        }
    }
}
