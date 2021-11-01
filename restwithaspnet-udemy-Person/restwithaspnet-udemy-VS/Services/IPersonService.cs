using System.Collections.Generic;
using restwithaspnet_udemy_VS.Model;

namespace restwithaspnet_udemy_VS.Services
{
   public interface IPersonService
    {
        Person Create(Person Person);

        Person FindById(long id);

        List<Person> FindAll();

        Person Update(Person Person);

        void Delete(long id);
    }
}
