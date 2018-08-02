using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using useing_mediatr_in_aspnet.Entities;

namespace useing_mediatr_in_aspnet.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();

        Task<Customer> GetByIdAsync(Guid id);

        Task SaveAsync(Customer customer);
    }
}
