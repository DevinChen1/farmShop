using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipAddressController : ControllerBase
    {
        private static List<ShipAddressInfo> shipAddressInfos = new List<ShipAddressInfo>();
        public ShipAddressController()
        { }
        // GET: api/ShipAddress
        /// <summary>
        /// 配送地址列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ShipAddressInfo> Get()
        {
            return shipAddressInfos;
        }
        
        // GET: api/ShipAddress/5
        [HttpGet("{id}", Name = "Get")]
        public ShipAddressInfo Get(string id)
        {
            var product = shipAddressInfos.SingleOrDefault(p => p.id == id);
            if (product == null)
            {
                Response.StatusCode = 404;
            }
            return product;
        }

        // POST: api/ShipAddress
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ShipAddress/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
