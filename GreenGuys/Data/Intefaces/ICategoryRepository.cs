using GreenGuys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGuys.Data.Intefaces
{
     public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get;}
    }
}
