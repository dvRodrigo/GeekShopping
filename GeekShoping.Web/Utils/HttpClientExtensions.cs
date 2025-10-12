using System.Net.Http.Headers;

namespace GeekShopping.Web.Utils
{
    public static class HttpClientExtensions
    {

        public static async Task<T> ReadContentAs<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");
            }
            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return System.Text.Json.JsonSerializer.Deserialize<T>(dataAsString, new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        public static Task<HttpResponseMessage> PostAsJson<T>(this HttpClient httpClient, string url, T item)
        {
            var itemAsString = System.Text.Json.JsonSerializer.Serialize(item);
            var content = new StringContent(itemAsString, System.Text.Encoding.UTF8, "application/json");
            return httpClient.PostAsync(url, content);
        }
        public static Task<HttpResponseMessage> PutAsJson<T>(this HttpClient httpClient, string url, T item)
        {
            var itemAsString = System.Text.Json.JsonSerializer.Serialize(item);
            var content = new StringContent(itemAsString, System.Text.Encoding.UTF8, "application/json");
            return httpClient.PutAsync(url, content);
        }
        public static Task<HttpResponseMessage> DeleteAsJson<T>(this HttpClient httpClient, string url, T item)
        {
            var itemAsString = System.Text.Json.JsonSerializer.Serialize(item);
            var request = new HttpRequestMessage
            {
                Content = new StringContent(itemAsString, System.Text.Encoding.UTF8, "application/json"),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url)
            };
            return httpClient.SendAsync(request);
        }
        public static Task<HttpResponseMessage> DeleteAsync(this HttpClient httpClient, string url)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url)
            };
            return httpClient.SendAsync(request);
        }
    }
}
