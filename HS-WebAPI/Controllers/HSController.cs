using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HS_WebAPI.Model;
using HS_WebAPI.Interface;

namespace HS_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HSController : ControllerBase
    {
        private readonly IHSService _service;

        public HSController(IHSService service)
        {
            _service = service;
        }

        //GET api/getallitems
        [HttpGet]
        public ActionResult<Item[]> Get()
        {
            Item[] allItems = _service.GetAllItems();
            if (allItems == null)
                return NotFound();

            return Ok(allItems);
        }

        //GET api/getbyid
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            Item item = _service.GetById(id);
            if (item == null)
                return NotFound();

            return item;
        }

        //Post api/shopping
        [HttpPost]
        public ActionResult Post([FromBody] Item item)
        {
            _service.Add(item);
            return CreatedAtAction("Get", new { id = item.guid }, item);
        }

        //DELETE api/delete
        [HttpDelete("{id}")]
        public ActionResult Remove(Guid id)
        {
            Item item = _service.GetById(id);
            if (item == null)
                return NotFound();

            _service.Delete(id);
            return Ok();
        }
    }

    public class FakeService : IHSService
    {
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
            throw new NotImplementedException();
        }
    }
}