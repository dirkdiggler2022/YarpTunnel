namespace YarpTunnel.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:5293/_yarp-tunnel?host=backend1");
                    response.EnsureSuccessStatusCode(); // Ensure success status code, throws exception otherwise

                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                }
            }
        }
    }
}