﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public int CategoryID { get; set; }

        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
