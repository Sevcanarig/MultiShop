using MultiShop.DtoLayer.Dtos.CatalogDtos.ProductDetailDtos;
using Newtonsoft.Json;
using System.Text.Json;

namespace MultiShop.WebUI.Services.CatalogServices.ProductDetailServices
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly HttpClient _httpClient;
        public ProductDetailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto)
        {
            await _httpClient.PostAsJsonAsync("productdetails", createProductDetailDto);
        }

        public async Task DeleteProductDetailAsync(string id)
        {
            await _httpClient.DeleteAsync("productdetails?id=" + id);
        }

        public async Task<GetByIdProductDetailDto?> GetByIdProductDetailAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("productdetails/" + id);

            if (!responseMessage.IsSuccessStatusCode)
                return null;

            var content = await responseMessage.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(content))
                return null;

            // System.Text.Json kullanımı, tam nitelikli isim ile
            var values = System.Text.Json.JsonSerializer.Deserialize<GetByIdProductDetailDto>(
                content,
                new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return values;
        }

        public async Task<List<ResultProductDetailDto>> GetAllProductDetailAsync()
        {
            var responseMessage = await _httpClient.GetAsync("productdetails");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(jsonData))
                return new List<ResultProductDetailDto>();

            // Newtonsoft.Json kullanımı
            var values = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ResultProductDetailDto>>(jsonData)
                         ?? new List<ResultProductDetailDto>();

            return values;
        }

        public async Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto)
        {
            await _httpClient.PutAsJsonAsync("productdetails", updateProductDetailDto);
        }

        public async Task<GetByIdProductDetailDto?> GetByProductIdProductDetailAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("productdetails/GetProductDetailByProductId/" + id);

            if (!responseMessage.IsSuccessStatusCode)
                return null;

            var content = await responseMessage.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(content))
                return null;

            var values = System.Text.Json.JsonSerializer.Deserialize<GetByIdProductDetailDto>(
                content,
                new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return values;
        }
    }
}
