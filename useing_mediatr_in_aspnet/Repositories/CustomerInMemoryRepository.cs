using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using useing_mediatr_in_aspnet.Entities;

namespace useing_mediatr_in_aspnet.Repositories
{
    public class CustomerInMemoryRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers;

        public CustomerInMemoryRepository()
        {
            _customers = new List<Customer>();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            var task = Task.Run<IEnumerable<Customer>>(() => { return _customers; });
            return await task;
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            var task = Task.Run<Customer>(()=> { return _customers.SingleOrDefault(x => x.Id == id); });
            return await task;
        }

        public async Task SaveAsync(Customer customer)
        {
            var guardTask = Task.Run<bool>(() => { return _customers.Any(x => x.Id == customer.Id); });
            var isExisting = await guardTask;
            if (isExisting)
                throw new ApplicationException("Customer exists");

            var saveTask = Task.Run(() => _customers.Add(customer));
            await saveTask;
        }
    }
}
