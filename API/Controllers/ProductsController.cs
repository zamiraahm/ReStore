using System.Text.Json;
using API.Data;
using API.Entities;
using API.Extensions;
using API.RequestHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  
    public class ProductsController : BaseApiController
    {
        private readonly StoreContext _context;
        public  ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        //[ApiExplorerSettings(GroupName = "v1")]
        public async Task<ActionResult<PagedList<Product>>> GetProducts([FromQuery]ProductParams productParams)
        {
            var query =  _context.Products
            .Sort(productParams.OrderBy)
            .Search(productParams.SearchTerm)
            .Filter(productParams.Authors, productParams.Genres)
            .AsQueryable();
           
                var products = await PagedList<Product>.ToPagedList(query, 
                    productParams.PageNumber, productParams.PageSize);
                
                Response.AddPaginationHeader(products.MetaData);

                return products;
        }


        [HttpGet("{id}")]
        //[ApiExplorerSettings(GroupName = "v2")]

        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if(product == null) return NotFound();

            return product;
        }
        [HttpGet("filters")]
        public async Task<IActionResult>GetFilters()
        {
            var authors = await _context.Products.Select(p=>p.Author).Distinct().ToListAsync();
            var genres = await _context.Products.Select(p=>p.Genre).Distinct().ToListAsync();

            return Ok(new {authors});
        }
    }
}