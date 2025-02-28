using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.WebAPI.Data;
using Yummy.WebAPI.DTOs.ContactDtos;
using Yummy.WebAPI.Entities;

namespace Yummy.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ContactsList()
        {
            var values = _context.Contacts.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult createContact(CreateContactDto createContact)
        {
            Contact contact=new Contact();
            contact.Email = createContact.Email;
            contact.Adresse = createContact.Adresse;
            contact.MapLocation = createContact.MapLocation;
            contact.Phone = createContact.Phone;
            contact.OpenHours = createContact.OpenHours;
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok("Der Benutzer hat es erfolgreich hinzugefügt. ");
        }
        [HttpDelete("{id}")]
        public IActionResult deleteContact(int id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
            return Ok("Der Benutzer wurde erfolgreich gelöscht. ");
        }
        [HttpGet("getContact")]
        public IActionResult getContact(int id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }
        [HttpPut]
        public IActionResult updateContact(UpdateContactDto updateContact)
        {
            var contact = _context.Contacts.Find(updateContact.Id);
            if (contact == null)
            {
                return NotFound();
            }
            contact.Id = updateContact.Id;
            contact.Email = updateContact.Email;
            contact.Adresse = updateContact.Adresse;
            contact.MapLocation = updateContact.MapLocation;
            contact.Phone = updateContact.Phone;
            contact.OpenHours = updateContact.OpenHours;
            _context.SaveChanges();
            return Ok("Der Benutzer wurde erfolgreich aktualisiert. ");
        }
    }
}
