using HS_WebAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_WebAPI.Model
{
    public class Item : IHSService
    {
        public Guid guid { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Item Add(Item newItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item[] GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetById(Guid id)
        {
            //throw new NotImplementedException();
            Item item = new Item();
            item.Name = "MyName";
            item.Price = 15;
            return item;
        }
    }
}
