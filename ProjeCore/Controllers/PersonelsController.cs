using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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


        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in context.Birims.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.BirimAd,
                                                  Value = x.BirimID.ToString()
                                              }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
    }
}
