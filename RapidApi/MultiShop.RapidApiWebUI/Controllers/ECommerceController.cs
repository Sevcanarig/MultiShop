using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApiWebUI.Models;
using Newtonsoft.Json;

namespace MultiShop.RapidApiWebUI.Controllers
{
    public class ECommerceController : Controller
    {
        public async Task<IActionResult> ECommerceList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-product-search.p.rapidapi.com/search-v2?q=iphone%20telefon&country=tr&language=en&page=1&limit=12&sort_by=BEST_MATCH&product_condition=ANY&return_filters=true"),
                Headers =
                {
                    { "x-rapidapi-key", "7d852f339bmsh261bec83d9f2ce1p1828fejsn077f04cc2862" },
                    { "x-rapidapi-host", "real-time-product-search.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                // JSON'u Rootobject olarak deserialize et
                var data = JsonConvert.DeserializeObject<ECommerceModel.Rootobject>(body);

                // Ürünler dizisini view'a gönder
                // View, Product[] modelini kabul edecek
                return View(data.data.products);
            }
        }
    }
}
