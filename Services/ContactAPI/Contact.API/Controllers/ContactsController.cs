using Contact.API.Infrastructure.AbstractServices;
using Contact.API.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            this._contactService = contactService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _contactService.GetContactById(id);
            return Ok(result);
        }
    }
}