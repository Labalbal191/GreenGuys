﻿using GreenGuys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGuys.Data.Intefaces
{
    interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get;}
    }
}
