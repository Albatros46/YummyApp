using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.WebAPI.Data;
using Yummy.WebAPI.Entities;

namespace Yummy.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values=_context.Categories.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("Kategorie erstellt!");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id) { 
            var value=_context.Categories.Find(id);
            _context.Categories.Remove(value);
            _context.SaveChanges();
            return Ok("Kategorie gelöscht!");
        }

        [HttpGet("GetCategoryById")]
        public IActionResult GetCategoryById(int id)
        {
            var values = _context.Categories.Find(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category) 
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("Die Kategorie wurde aktualisiert!");
        }
    }
}
