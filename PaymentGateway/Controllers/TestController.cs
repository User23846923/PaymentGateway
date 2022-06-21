using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaymentGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<string> TestGet()
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage();

            request.RequestUri = new Uri("http://acquiringbank/api/Names/1");
            var response = await client.SendAsync(request);
            var name = await response.Content.ReadAsStringAsync();
            return name;
        }
    }
}
