using GreenGuys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGuys.Data.Intefaces
{
    interface IPlantRepository
    {
        IEnumerable<Plant> Plants { get;}
        IEnumerable<Plant> MostPopularPlant { get;}
        Plant GetPlantById(int plantId);
    }
}
