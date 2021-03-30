using GreenGuys.Data.Intefaces;
using GreenGuys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGuys.Data.Mocks
{
    public class MockPlantRepository : IPlantRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Plant> Plants
        {
            get
            {
                return new List<Plant>
                {
                    new Plant
                    {
                        Name = "Rose",
                        Price = 5.5M,
                        ShortDescription = "The Hibiscus rosa-sinensis has the common name of Rose of China, and originated in China.",
                        LongDescription = "The flowers are a kind of trumpet shape and bright in color. These are fairly easy-to-care for, but need plenty of light.",
                        Category = _categoryRepository.Categories.First(),
                        ImageURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        ImageThumbnailURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        InStock = true,
                        IsMostPopular = true,
                    },
                    new Plant
                    {
                        Name = "Cactus",
                        Price = 10M,
                        ShortDescription = "This cactus is more suitable for growing in rockery settings within a garden.",
                        LongDescription = "They do flower, although it seems to be quite hard to get them to bloom. This globular shaped cacti is available with spines and spineless.",
                        Category = _categoryRepository.Categories.First(),
                        ImageURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        ImageThumbnailURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        IsMostPopular = true,
                    },
                    new Plant
                    {
                        Name = "Aloe",
                        Price = 15.5M,
                        ShortDescription = "Aloe Vera is a succulent leaf plant ",
                        LongDescription = "These are said to originate from Africa and they are grown/cultivated in various countries and homes, because they tolerate various conditions very well.",
                        Category = _categoryRepository.Categories.First(),
                       ImageURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        ImageThumbnailURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        InStock = true,
                        IsMostPopular = true,
                    },
                    new Plant
                    {
                        Name = "Venus Fly Trap",
                        Price = 37.5M,
                        ShortDescription = "The dionaea muscipula is unusual in the way that it traps insects and ingests them",
                        LongDescription = "It's the most commonly kept insectivore indoors, although it's quite hard to extend their life span to the level they live up to outdoors.",
                        Category = _categoryRepository.Categories.Last(),
               ImageURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        ImageThumbnailURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        InStock = true,
                        IsMostPopular = false,
                    }
                    
                };
            }
        }
        public IEnumerable<Plant> MostPopularPlant { get; }

        public Plant GetPlantById(int plantId)
        {
            throw new NotImplementedException();
        }
    }
}
