using Microsoft.AspNetCore.Mvc;

namespace ProjeCore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GirisYap()
        {
            return View();
        }
    }
}
