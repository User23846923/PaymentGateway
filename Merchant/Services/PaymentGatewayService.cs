namespace Merchant.Services
{
    public class PaymentGatewayService
    {
        public async Task<string> TestGet(int index)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri($"http://paymentgateway/api/Test/{index}")
            };
            var response = await client.SendAsync(request);
            var name = await response.Content.ReadAsStringAsync();
            return name;
        }
    }
}
