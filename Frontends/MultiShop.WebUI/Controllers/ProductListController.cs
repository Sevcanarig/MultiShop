using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.Dtos.CommentDtos;
using MultiShop.DtoLayer.Dtos.CatalogDtos.ProductDtos;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Controllers
{
    public class ProductListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IProductService _productService; // <-- burası eklendi

        public ProductListController(IHttpClientFactory httpClientFactory, IProductService productService)
        {
            _httpClientFactory = httpClientFactory;
            _productService = productService; // <-- inject edildi
        }

        // Tüm ürünleri listele
        public async Task<IActionResult> Index()
        {
            ViewBag.directory1 = "Ana Sayfa";
            ViewBag.directory2 = "Ürünler";
            ViewBag.directory3 = "Ürün Listesi";

            var products = await _productService.GetAllProductAsync(); // <-- burada artık kullanabiliyoruz
            return View(products);
        }

        // Ürün detay sayfası
        public IActionResult ProductDetail(string id)
        {
            ViewBag.directory1 = "Ana Sayfa";
            ViewBag.directory2 = "Ürün Listesi";
            ViewBag.directory3 = "Ürün Detayları";
            ViewBag.x = id;
            return View();
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentDto createCommentDto)
        {
            createCommentDto.ImageUrl = "test";
            createCommentDto.Rating = 1;
            createCommentDto.CreatedDate = DateTime.Now;
            createCommentDto.Status = false;
            createCommentDto.ProductId = "68cf07172c23d48b5f51adcd";

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCommentDto);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:7135/api/Comments", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "ProductList");
            }

            return View();
        }
    }
}
