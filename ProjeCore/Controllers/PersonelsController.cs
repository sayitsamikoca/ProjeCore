using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjeCore.Models;

namespace ProjeCore.Controllers
{
    public class PersonelsController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var degerler = context.Personels.Include(x => x.Birim).ToList();

            return View(degerler);
        }
    }
}
