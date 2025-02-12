using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.WebAPI.Data;
using Yummy.WebAPI.Entities;

namespace Yummy.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ChefsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ChefsList()
        {
            var values= _context.Chefs.ToList();
            return Ok(values);
        }

        [HttpGet("ChefById")]
        public IActionResult getByIdChef(int id) 
        {
            return Ok(_context.Chefs.Find(id));
        }

        [HttpPost]
        public IActionResult createChef(Chef chef)
        {
           _context.Chefs.Add(chef);
            _context.SaveChanges();
            return Ok("Der Benutzer hat es erfolgreich hinzugefügt. ");
        }

        [HttpDelete]
        public IActionResult deleteChef(int chefId) 
        { 
            var value=_context.Chefs.Find(chefId);
            _context.Chefs.Remove(value);
            _context.SaveChanges();
            return Ok("Der Benutzer wurde erfolgreich gelöscht. ");
        }

        [HttpPut]
        public IActionResult updateChef(Chef chef)
        {
            _context.Chefs.Update(chef);
            _context.SaveChanges();
            return Ok("Der Benutzer wurde erfolgreich aktualisiert. ");
        }
    }
}
