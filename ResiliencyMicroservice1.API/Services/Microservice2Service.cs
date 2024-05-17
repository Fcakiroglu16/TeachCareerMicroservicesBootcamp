namespace ResiliencyMicroservice1.API.Services
{
    public class Microservice2Service(HttpClient client)
    {
        public async Task<string> GetProducts()
        {
            var response = await client.GetAsync("api/products");
            return await response.Content.ReadAsStringAsync();
        }
    }
}