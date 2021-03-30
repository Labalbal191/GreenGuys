using GreenGuys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGuys.ViewModels
{
    public class PlantListViewModel
    {
        public IEnumerable<Plant> Plants { get; set; }
        public string CurrentCategory { get; set; }
    }
}
