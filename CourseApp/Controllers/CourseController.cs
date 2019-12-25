using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Microsoft.AspNetCore.Mvc.Controller
    {
        public string Index()
        {
            return "/Course/Index";
        }
    }
}