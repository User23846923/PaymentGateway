using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcquiringBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        private readonly string[] _names = {"Bert", "Ethel"};

        [HttpGet("{index}")]
        public string Get(int index)
        {
            return _names[index];
        }
    }
}
