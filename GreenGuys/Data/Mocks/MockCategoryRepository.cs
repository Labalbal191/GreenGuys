using GreenGuys.Data.Intefaces;
using GreenGuys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGuys.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryName = "Common House Plants", Description = "Common and popular plants found inside many homes"},
                    new Category{ CategoryName = "Flowering Plants", Description = "It's impossible to resist growing flowering plant types indoors."},
                    new Category{ CategoryName = "Cactus Plants", Description = "If you have enough light and warmth you can grow cacti."},
                    new Category{ CategoryName = "Easy & Low Light", Description = "Plants best for the begginers"},
                    new Category{ CategoryName = "Unusual Plants", Description = "A collection of plants grown indoors that have an unusual appearance"}
                };
            }
        }
    }
}
