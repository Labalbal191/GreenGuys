using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGuys.Data.Models
{
    public class Plant
    {
        public int PlantId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageURL { get; set; }
        public string ImageThumbnailURL { get; set; }
        public decimal Price { get; set; }
        public bool IsMostPopular { get; set; }
        public int CategoryId { get; set; }
        public bool InStock { get; set; }
        public virtual Category Category { get; set; }
    }
}
