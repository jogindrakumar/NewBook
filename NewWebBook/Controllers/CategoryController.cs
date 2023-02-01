using Microsoft.AspNetCore.Mvc;

namespace NewWebBook.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
