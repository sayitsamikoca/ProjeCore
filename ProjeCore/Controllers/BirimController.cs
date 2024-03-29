﻿using Microsoft.AspNetCore.Mvc;
using ProjeCore.Models;
using System.Linq;

namespace ProjeCore.Controllers
{
    public class BirimController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var degerler = context.Birims.ToList();
            return View(degerler);
        }


        [HttpGet] // Sayfa yüklendiği zaman burası çalışcak.
        public IActionResult YeniBirim()
        {
            return View();
        }

        [HttpPost] // Sayfamda bir post işlemi olursa burası çalışacak
        public IActionResult YeniBirim(Birim birim)
        {
            //Departman Ekleme İşlemi

            context.Birims.Add(birim);

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        // **************************************************************************************

        public IActionResult BirimSil(int id)
        {
            var birim = context.Birims.Find(id);
            context.Birims.Remove(birim);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult BirimGetir(int id)
        {
            // Departman Update işlemi için sayfaya id taşıma...

            var birim = context.Birims.Find(id);
            return View("BirimGetir", birim);
        }

        public IActionResult BirimGuncelle(Birim birim)
        {
            var birimdeger = context.Birims.Find(birim.BirimID);
            birimdeger.BirimAd = birim.BirimAd;
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult BirimDetay(int id) // Detaylara tıkladığımda, o birime ait personeller listelenecek.
        {
            // Personel içerisinde BirimID eşittir, dışarıdan gönderien id ye eşit olan değerleri liste halinde getir
            var degerler = context.Personels.Where(x => x.BirimID == id).ToList();

            var birimValue = context.Birims.Where(x => x.BirimID == id).Select(y => y.BirimAd).FirstOrDefault();
            // FirstOrDefault bana birtane veri getir..

            ViewBag.birimVal = birimValue;
            return View(degerler);
        }


    }
}
