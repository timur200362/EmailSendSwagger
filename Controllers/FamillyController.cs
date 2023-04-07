using Dogs.WebApi.Data;
using Dogs.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dogs.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamillyController : ControllerBase
    {
        // GET: api/<DogsController>
        [HttpGet("get-all")]
        public IEnumerable<Family> GetFamily()
        {
            return DataSeeds.FamilyList;
        }
    }
}
