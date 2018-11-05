using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressService.Domain.AppServices;
using AddressService.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipAddressInfoesController : ControllerBase
    {
        private ShipAddressInfoesAppService _shipAddressInfoesAppService;
        public ShipAddressInfoesController(ShipAddressInfoesAppService shipAddressInfoesAppService) {
            this._shipAddressInfoesAppService=shipAddressInfoesAppService;

        }
        // GET: api/ShipAddressInfoes
        [HttpGet]
        public IEnumerable<ShipAddressInfo> GetAllWith_uid(string uid)
        {
           return _shipAddressInfoesAppService.GetShipAddressInfos(uid);
        }

        [HttpGet]
        public async Task<ShipAddressInfo> GetWith_saidAsync(string said)
        {
            return await _shipAddressInfoesAppService.GetShipAddressInfoAsync(said);
        }

        [HttpPost]
        public async Task<int> CreateAsync(ShipAddressInfo shipAddressInfo)
        {
            return await _shipAddressInfoesAppService.CreateShipAddressInfoAsync(shipAddressInfo);
        }

        [HttpPost]
        public async Task<int> UpdateAsync(ShipAddressInfo shipAddressInfo)
        {
            return await _shipAddressInfoesAppService.UpdateShipAddressInfoAsync(shipAddressInfo);
        }

        [HttpPost]
        public async Task<int> Delete(string   said)
        {
            return await _shipAddressInfoesAppService.DeleteShipAddressInfoAsync(said);
        }
    }
}
