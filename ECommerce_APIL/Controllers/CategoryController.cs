using ECommerce_BusinessL.IServices;
using ECommerce_BusinessL.IServicesImpl;
using ECommerce_DAL.IServices;
using ECommerce_EntityL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_APIL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryservice;

          public CategoryController(ICategoryService categoryService)
        {
           this._categoryservice = categoryService;
        }

        [HttpGet("/categories")]
        public async Task<IActionResult> GetAllCategories()
        {
            IQueryable < Category> categoryresult=_categoryservice.GetAll();
            return Ok(categoryresult);
        }
    }
}
