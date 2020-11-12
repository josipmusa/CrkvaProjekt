using CrkvaProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrkvaProjekt.ViewModels
{
    public class NovostiPrikaziVM
    {
        public List<Novosti> Novosti { get; set; }
        public int CurrentPageIndex { get; set; }

        public int PageCount { get; set; }
    }
}
