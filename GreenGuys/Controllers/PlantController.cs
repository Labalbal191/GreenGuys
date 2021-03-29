using GreenGuys.Data.Intefaces;
using GreenGuys.Data.Mocks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGuys.Controllers
{
    public class PlantController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPlantRepository _plantRepository;
        
        public PlantController(ICategoryRepository categoryRepository, IPlantRepository plantRepository)
        {
            _categoryRepository = categoryRepository;
            _plantRepository = plantRepository;
        }

        public ViewResult List()
        {
            var plants = _plantRepository.Plants;   
            return View(plants);
        }
    }
}
