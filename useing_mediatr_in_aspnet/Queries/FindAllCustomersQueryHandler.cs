using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using useing_mediatr_in_aspnet.Entities;
using useing_mediatr_in_aspnet.Repositories;

namespace useing_mediatr_in_aspnet.Queries
{
    public class FindAllCustomersQueryHandler : IRequestHandler<FindAllCustomersQuery, IEnumerable<Customer>>
    {
        private readonly ICustomerRepository _customerRepository;

        public FindAllCustomersQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> Handle(FindAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return await _customerRepository.GetAllAsync();
        }
    }
}
