using AutoMapper;
using AutoMapperUse.Homework.Dto;
using AutoMapperUse.Homework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperUse.Homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMapper? _mapper;
        public PersonController(IMapper mapper)
        {
            _mapper= mapper;
        }

        [HttpPost]
        public IActionResult Post(PersonDto personDto) 
        {
            Person person = _mapper.Map<Person>(personDto);
            return Ok(person);
        }
    }
}
