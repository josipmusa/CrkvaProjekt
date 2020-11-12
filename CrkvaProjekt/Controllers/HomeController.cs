using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrkvaProjekt.Models;
using CrkvaProjekt.Data;
using CrkvaProjekt.ViewModels;
using CrkvaProjekt.ViewModels.Obavjestenja;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CrkvaProjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString, int pageNumber=1)
        {

           var query = _context.Obavjestenja.OrderByDescending(x => x.DatumObjavljivanja).Select(x => new ObavjestenjaPrikaziVM
            {
                ObavjestenjaID=x.ObavjestenjaID,
                Slika=x.Slika,
                Naslov=x.Naslov,
                DatumObjavljivanja=x.DatumObjavljivanja,
                ObavjestenjeKategorija=x.ObavjestenjaKategorije.Naziv,
                Text=x.Text
            }).AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(x => x.Naslov.Contains(searchString));
            }
            int pageSize = 5;
            return View(await PaginatedList<ObavjestenjaPrikaziVM>.CreateAsync(query.AsNoTracking(),pageNumber,pageSize));
        }
        public async Task<IActionResult> IndexNovosti(string searchString, int pageNumber = 1)
        {
            var novosti = _context.Novosti.OrderByDescending(x => x.DatumObjavljivanja).AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
            {
                novosti = novosti.Where(x => x.Naslov.Contains(searchString));
            }
            int pageSize = 5;
            return View(await PaginatedList<Novosti>.CreateAsync(novosti.AsNoTracking(), pageNumber, pageSize));
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Linkovi()
        {
            return View();
        }
        public IActionResult Kontakti()
        {
            return View();
        }
        public IActionResult Istorija()
        {
            return View();
        }
        public IActionResult IstorijaHercegovina()
        {
            return View();
        }
        public IActionResult IstorijaMostar()
        {
            return View();
        }
        public IActionResult Parohije()
        {
            return View();
        }
        public IActionResult ParohijaPrva()
        {
            return View();
        }
        public IActionResult ParohijaDruga()
        {
            return View();
        }
        public IActionResult ParohijaTreca()
        {
            return View();
        }
        public IActionResult ParohijaZitomislic()
        {
            return View();
        }
        public IActionResult Zdanja()
        {
            return View();
        }
        public IActionResult Hramovi()
        {
            return View();
        }
        public IActionResult Groblja()
        {
            return View();
        }
        public IActionResult Vladicanski()
        {
            return View();
        }
        public IActionResult Zgrada()
        {
            return View();
        }
        public IActionResult Sredista()
        {
            return View();
        }
        public IActionResult Manastir()
        {
            return View();
        }
        public IActionResult Saborni()
        {
            return View();
        }
        public IActionResult Stara()
        {
            return View();
        }
        public IActionResult Blagaj()
        {
            return View();
        }
        public IActionResult Vaznesenje()
        {
            return View();
        }
        public IActionResult GrobljeBjelusine()
        {
            return View();
        }
        public IActionResult GrobljePasinovac()
        {
            return View();
        }
        public IActionResult GrobljeStara()
        {
            return View();
        }
        public IActionResult Riznica()
        {
            return View();
        }
        public IActionResult Biblioteka()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
