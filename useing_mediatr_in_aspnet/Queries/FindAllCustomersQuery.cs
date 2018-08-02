using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using useing_mediatr_in_aspnet.Entities;

namespace useing_mediatr_in_aspnet.Queries
{
    public class FindAllCustomersQuery : IRequest<IEnumerable<Customer>>
    {
        public FindAllCustomersQuery()
        {
        }
    }
}
