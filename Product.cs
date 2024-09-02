﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePolyMorpism
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }

        public string DisplayProduct()
        {
            return $" {Id } - { Name } - { Rate} ";
        }
    }


}
