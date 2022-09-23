using Contact.API.Models.Models;

namespace Contact.API.Infrastructure.AbstractServices
{
    public interface IContactService
    {
        ContactDto GetContactById(int id);
    }
}