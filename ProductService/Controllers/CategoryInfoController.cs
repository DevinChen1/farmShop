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
    public class CategoryInfoController : ControllerBase
    {
        private CategoryInfoAppService _categoryInfoAppService;
        public CategoryInfoController(CategoryInfoAppService categoryInfoAppService) {
            this._categoryInfoAppService=  categoryInfoAppService;
        }
        // GET: api/CategoryInfo
        [HttpGet]
        public IEnumerable<CategoryInfo> GetCategoryInfoList()
        {
            return _categoryInfoAppService.GetCategoryInfoList();
        }

        // GET: api/CategoryInfo/5
        [HttpGet("{id}", Name = "GetCategoryInfo")]
        public async Task< CategoryInfo> GetCategoryInfo(string id)
        {
            return await _categoryInfoAppService.GetCategoryInfoAsync(id);
        }
        // POST: api/CategoryInfo
        [HttpPost]
        public async Task<int> CreateCategoryInfo(CategoryInfo categoryInfo)
        {
            return await _categoryInfoAppService.CreateCategoryInfoAsync(categoryInfo);
        }
        // POST: api/UpdateCategoryInfo
        [HttpPost]
        public async Task<int> UpdateCategoryInfo(CategoryInfo categoryInfo)
        {
            return await _categoryInfoAppService.UpdateCategoryInfoAsync(categoryInfo);
        }


        // POST: api/DeleteCategoryInfo
        [HttpPost]
        public async Task<int> DeleteCategoryInfo(string id)
        {
            return await _categoryInfoAppService.DeleteCategoryInfoAsync(id);
        }


    }
}
