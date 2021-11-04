﻿using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System.Collections.Generic;
using System.Threading;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        // Counter responsible for generating a fake ID
        // since we are not accessing any database
        private MysqlContext _Context;

    public PersonServiceImplementation(MySQLContext context)
    {
            _Context = context;
    }
        public Person Create(Person person)
        {
            return person;
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            // Our exclusion logic would come here
        }

        // Method responsible for returning all people,
        // again this information is mocks
        public List<Person> FindAll()
        {
            return _Context.Persons.ToList;
        }

        // Method responsible for returning a person
        // as we have not accessed any database we are returning a mock
        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlandia - Minas Gerais - Brasil",
                Gender = "Male"
            };
        }

        // Method responsible for updating a person for
        // being mock we return the same information passed
        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
