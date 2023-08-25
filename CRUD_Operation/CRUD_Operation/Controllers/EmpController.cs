using Microsoft.AspNetCore.Mvc;

namespace CRUD_Operation.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
