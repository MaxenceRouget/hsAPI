using HS_WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_WebAPI.Interface
{
   public interface IHSService
    {
        Item Add(Item newItem);
        void Delete(Guid id);
        Item GetById(Guid id);

        Item[] GetAllItems();
    }
}
