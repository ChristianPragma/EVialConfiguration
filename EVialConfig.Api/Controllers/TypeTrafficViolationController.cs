using EVialConfig.Domain.Dtos;
using EVialConfig.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EVialConfig.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeTrafficViolationController : ControllerBase
    {
        private readonly ITypeTrafficViolationService _typeTrafficViolationService;
        public TypeTrafficViolationController(ITypeTrafficViolationService typeTrafficViolationService)
        {
            _typeTrafficViolationService = typeTrafficViolationService;
        }

        // GET: api/<TypeTrafficViolationController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetTypeTrafficViolationResponseDto>>> Get()
        {
            IEnumerable<GetTypeTrafficViolationResponseDto> result;
            result = await _typeTrafficViolationService.GetTrafficViolationsAsync(null);
            return Ok(result);
            // public async Task<IActionResult<IEnumerable<GetTypeTrafficViolationResponseDto>>> Get()
            // Buscar diferencia entre "IActionResult" con "ActionResult"
        }

        // GET api/<TypeTrafficViolationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TypeTrafficViolationController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateTypeTrafficViolationRequestDto requestDto)
        {
            await _typeTrafficViolationService.InsertTypeTrafficViolationAsync(requestDto);
            return Ok();
        }

        // PUT api/<TypeTrafficViolationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TypeTrafficViolationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
