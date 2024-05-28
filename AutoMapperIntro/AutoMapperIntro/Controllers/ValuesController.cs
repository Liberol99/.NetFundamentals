using AutoMapper;
using AutoMapperIntro.Dtos;
using AutoMapperIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperIntro.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        [ActionName("PostPerson")]
        public IActionResult PostPerson([FromBody] PersonDto personDto)
        {
            Person person = _mapper.Map<Person>(personDto);

            return Ok(person);
        }

        [HttpPost]
        [ActionName("PostPersons")]
        public IActionResult PostPersons([FromBody] List<PersonDto> personDtos)
        {
            List<Person> persons = _mapper.Map<List<PersonDto>, List<Person>>(personDtos);

            return Ok(persons);
        }

        [HttpPost]
        [ActionName("PostCustomer")]
        public IActionResult PostCustomer([FromBody] CustomerDto customerDto)
        {
            Customer customer = _mapper.Map<Customer>(customerDto);

            return Ok(customer);
        }

        [HttpPost]
        [ActionName("PostCustomers")]
        public IActionResult PostCustomers([FromBody] List<CustomerDto> customerDtos)
        {
            List<Customer> customers = _mapper.Map<List<CustomerDto>, List<Customer>>(customerDtos);

            return Ok(customers);
        }
    }
}
