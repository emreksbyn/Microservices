using Contact.API.Infrastructure.AbstractServices;
using Contact.API.Models.Models;

namespace Contact.API.Services.ConcreteServices
{
    public class ContactService : IContactService
    {
        public ContactDto GetContactById(int id)
        {
            return new ContactDto()
            {
                Id = id,
                FirstName = "Emre",
                LastName = "Kisaboyun"
            };
        }
    }
}