using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using useing_mediatr_in_aspnet.Entities;
using useing_mediatr_in_aspnet.Repositories;

namespace useing_mediatr_in_aspnet.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.Id, request.FirstName, request.LastName);

            await _customerRepository.SaveAsync(customer);

            return Unit.Value;
        }
    }
}
