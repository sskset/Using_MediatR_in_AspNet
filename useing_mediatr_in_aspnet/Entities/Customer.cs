using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace useing_mediatr_in_aspnet.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Customer(Guid id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
