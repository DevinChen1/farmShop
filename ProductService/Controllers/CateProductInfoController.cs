using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Domain.AppServices;
using ProductService.Domain.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CateProductInfoController : ControllerBase
    {
        private CateProductInfoAppService _cateProductInfoAppService;
        public CateProductInfoController(CateProductInfoAppService cateProductInfoAppService) {
            this._cateProductInfoAppService=  cateProductInfoAppService;
        }
        // GET: api/CateProductInfo
        [HttpGet]
        public IEnumerable<CateProductInfo> GetCateProductInfoList()
        {
            return _cateProductInfoAppService.GetCateProductInfoList();
        }

        // GET: api/CateProductInfo/5
        [HttpGet]
        public async Task< CateProductInfo> GetCateProductInfo(string id)
        {
            return await _cateProductInfoAppService.GetCateProductInfoAsync(id);
        }
        // POST: api/CateProductInfo
        [HttpPost]
        public async Task<int> CreateCateProductInfo(CateProductInfo CateProductInfo)
        {
            return await _cateProductInfoAppService.CreateCateProductInfoAsync(CateProductInfo);
        }
        // POST: api/UpdateCateProductInfo
        [HttpPost]
        public async Task<int> UpdateCateProductInfo(CateProductInfo CateProductInfo)
        {
            return await _cateProductInfoAppService.UpdateCateProductInfoAsync(CateProductInfo);
        }


        // POST: api/DeleteCateProductInfo
        [HttpPost]
        public async Task<int> DeleteCateProductInfo(string id)
        {
            return await _cateProductInfoAppService.DeleteCateProductInfoAsync(id);
        }


    }
}
