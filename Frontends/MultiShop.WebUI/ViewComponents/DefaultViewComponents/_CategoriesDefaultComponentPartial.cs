using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.Dtos.CatalogDtos.CategoryDtos;
using MultiShop.DtoLayer.Dtos.CatalogDtos.ProductDtos;
using MultiShop.WebUI.Services.CatalogServices.CategoryServices;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;

namespace MultiShop.WebUI.ViewComponents.DefaultViewComponents
{
    public class _CategoriesDefaultComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public _CategoriesDefaultComponentPartial(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Tüm kategoriler
            var categories = await _categoryService.GetAllCategoryAsync();

            // Tüm ürünler
            var products = await _productService.GetAllProductAsync();

            // Her kategori için ürün sayısını hesapla
            foreach (var category in categories)
            {
                category.ProductCount = products.Count(p => p.CategoryId == category.CategoryId);
            }

            return View(categories);
        }
    }
}
