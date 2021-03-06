using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    [table("person")]
    public class Person
    {
        [column("id")]
        public long Id { get; set; }
        [column("first_name")]
        public string FirstName { get; set; }
        [column("last_name")]
        public string LastName { get; set; }
        [column("address")]
        public string Address { get; set; }
        [column("gender")]
        public string Gender { get; set; }
    }
}
