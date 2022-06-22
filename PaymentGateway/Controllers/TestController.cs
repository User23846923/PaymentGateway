using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaymentGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("{index}")]
        public async Task<string> TestGet(int index)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri($"http://acquiringbank/api/Names/{index}")
            };
            var response = await client.SendAsync(request);
            var name = await response.Content.ReadAsStringAsync();
            return name;
        }
    }
}
