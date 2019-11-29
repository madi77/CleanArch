using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArch.Mvc.Controllers
{
    
    public class CourseController : Controller
    {
        private ICoursService _coursService;
        public CourseController(ICoursService coursService)
        {
            _coursService = coursService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CourseViewModel model = _coursService.GetCourses();
            return View(model);
        }
    }
}
