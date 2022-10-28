namespace DiffancyAssignment.Services
{
    public static class ExternalService
    {
        public static async Task<T> GetAsync<T>(this HttpClient client, string url)
        {
            var response = await client.GetAsync(url);
            var stringResult = await response.Content.ReadAsStringAsync();
            return Serializer.JsonDeSerialize<T>(stringResult);
        }
    }
}