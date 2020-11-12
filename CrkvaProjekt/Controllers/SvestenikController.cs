using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrkvaProjekt.Data;
using CrkvaProjekt.ViewModels.Svestenici;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CrkvaProjekt.Controllers
{
    public class SvestenikController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public SvestenikController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<ViewResult> Prikazi()
        {
            List<SvestenikPrikaziVM> model = new List<SvestenikPrikaziVM>();
            var items = await _userManager.GetUsersInRoleAsync("Svestenik");
            foreach(var item in items)
            {
                model.Add(new SvestenikPrikaziVM { SvestenikID = item.Id, Email = item.Email });
            }
            ViewData["svestenici-kljuc"] = model;
            return View();
        }
        public IActionResult ConfirmObrisi(string SvestenikID)
        {
            IdentityUser svestenik = _context.Users.Find(SvestenikID);
            SvestenikPrikaziVM model = new SvestenikPrikaziVM { SvestenikID = svestenik.Id, Email = svestenik.Email };
            return View(model);
        }
        public IActionResult Obrisi(string SvestenikID)
        {
            IdentityUser svestenik = _context.Users.Find(SvestenikID);
            if (svestenik == null)
            {
                TempData["error_poruka"] = "Sveštenik ne postoji. ";
                return RedirectToAction("Prikazi");
            }
            else
            {
                _context.Remove(svestenik);
                try
                {
                    _context.SaveChanges();
                }
                catch
                {
                    TempData["error_poruka"] = "Nemoguće izbrisati sveštenika trenutno. Vezan je za nešto u bazi. ";
                }
                TempData["success_poruka"] = "Uspješno ste izbrisali sveštenika. ";
            }
            return RedirectToAction("Prikazi");
        }
    }
}
