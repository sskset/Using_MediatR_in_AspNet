using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using useing_mediatr_in_aspnet.Commands;
using useing_mediatr_in_aspnet.Dtos;
using useing_mediatr_in_aspnet.Entities;
using useing_mediatr_in_aspnet.Queries;

namespace useing_mediatr_in_aspnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAll()
        {
            var query = new FindAllCustomersQuery();
            return await _mediator.Send(query);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] CreateCustomerDto dto)
        {
            try
            {
                var command = new CreateCustomerCommand(Guid.NewGuid(), dto.FirstName, dto.LastName);
                var result = await _mediator.Send(command);
            }
            catch(Exception ex)
            {

            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
