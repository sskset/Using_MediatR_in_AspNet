using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using useing_mediatr_in_aspnet.Entities;

namespace useing_mediatr_in_aspnet.Dtos
{
    public class CreateCustomerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public static class CreateCustomerDtoExtensions
    {
        public static Customer ToCustomer(this CreateCustomerDto dto)
        {
            return new Customer(Guid.NewGuid(), dto.FirstName, dto.LastName);
        }
    }
}
