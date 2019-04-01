using HS_WebAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_WebAPI.Model
{
    public class Item
    {
        public Guid guid { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
