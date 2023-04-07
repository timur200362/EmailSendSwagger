using Dogs.WebApi.Data;
using Dogs.WebApi.Models;
using Dogs.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dogs.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogsController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public DogsController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        //// GET: api/<DogsController>
        //[HttpGet]
        //public IEnumerable<DogShortInfo> Get()
        //{
        //    return DataSeeds.DogsList.Select(c => new DogShortInfo()
        //    {
        //        Name=c.Name,
        //        ImgUrl=c.ImgUrl,
        //        Family=c.Family?.Name ?? "пусто",
        //        Id=c.Id,
        //    });
        //}

        //// GET api/<DogsController>/5
        //[HttpGet("{id}")]
        //public Dog Get(Guid id)
        //{
        //    return DataSeeds.DogsList.FirstOrDefault(c => c.Id == id);
        //}

        //// POST api/<DogsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<DogsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<DogsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        //post mail
        [HttpPost("test")]
        public IActionResult SendEmailMessage([FromForm] string email, [FromForm] string comment, [FromForm] string tel)
        {
            _emailService.SendEmailAsync(email, "TEST", comment + $"телефон:{tel}");

            return Ok();
        }
    }
}
