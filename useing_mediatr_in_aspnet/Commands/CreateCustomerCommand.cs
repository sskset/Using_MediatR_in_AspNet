using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace useing_mediatr_in_aspnet.Commands
{
    public class CreateCustomerCommand : IRequest
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public CreateCustomerCommand(Guid customerId, string firstName, string lastName)
        {
            this.Id = customerId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
