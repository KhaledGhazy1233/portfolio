using Microsoft.AspNetCore.Mvc;

namespace KhaledGhazy.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
