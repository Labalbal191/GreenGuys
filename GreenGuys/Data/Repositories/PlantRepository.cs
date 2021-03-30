using GreenGuys.Data.Intefaces;
using GreenGuys.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGuys.Data.Repositories
{
    public class PlantRepository : IPlantRepository
    {
        private readonly AppDbContext _appDbContext;
        public PlantRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Plant> Plants => _appDbContext.Plants.Include(c => c.Category);

        public IEnumerable<Plant> MostPopularPlant => _appDbContext.Plants.Where(p => p.IsMostPopular).Include(c => c.Category);

        public Plant GetPlantById(int plantId) => _appDbContext.Plants.FirstOrDefault(p => p.PlantId == plantId);
    }
}
