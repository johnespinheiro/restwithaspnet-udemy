using restwithaspnet_udemy_VS.Model;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restwithaspnet_udemy_VS.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService  //classe implementa a interface criada - ipersonservice
    {
        private volatile int count;

        public Person Create(Person Person)
        {
            return Person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()  //retorna uma listagem de pessoas 
        {
            List<Person> persons = new List<Person>();  //laco for para rodar enquanto n chega a 8
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }



        public Person FindById(long id)  //retorna uma pessoa
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Johnes",
                LastName = "Pinheiro",
                Address = "angra",
                Gender = "Male"
            };
        }

        public Person Update(Person Person)
        {
            return Person;
        }
        
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" +i,
                LastName = "Person Lastname" +i,
                Address = "Some Address" +i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
