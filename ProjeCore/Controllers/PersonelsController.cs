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
            List<SelectListItem> degerler = (from item in context.Birims.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = item.BirimAd,
                                                  Value = item.BirimID.ToString()
                                              }).ToList();
            ViewBag.values = degerler;
            return View();
        }

        [HttpPost]
        public IActionResult YeniPersonel(Personel personel)
        {
            var personels = context.Birims.Where(x => x.BirimID == personel.Birim.BirimID).FirstOrDefault();
            personel.Birim = personels;
            context.Personels.Add(personel);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
