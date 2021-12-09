using System;
using Microsoft.AspNetCore.Mvc;
using ProtoTestApi.Protobuf;

namespace ProtoTestApi.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create([FromBody] CreatePersonRequest personRequest)
        {
            var person = new CreatePersonResponse {
               //Name = personRequest.Name,
               Email = personRequest.Email,
               Created = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
               StatusType = StatusType.Active
            };
            
            return Ok(person);
        }
    }
}