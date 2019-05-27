using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbMigrations.Model
{
    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }
    }
}
