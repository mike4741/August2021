using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogContext _catalog;
        public CatalogController(CatalogContext context)
        {
            _catalog = context;

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> Items(
           [FromQuery] int pageIndex= 0 , 
           [FromQuery] int pageSize = 6)
        {
         var  Items =  await _catalog.CatalogItems
                .OrderBy(c => c.Name)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}
