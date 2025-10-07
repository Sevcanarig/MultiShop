using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.Dtos.CatalogDtos.ProductDetailDtos;
using MultiShop.WebUI.Services.CatalogServices.ProductDetailServices;

namespace MultiShop.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailDescriptionComponentPartial : ViewComponent
    {
        private readonly IProductDetailService _productDetailService;

        public _ProductDetailDescriptionComponentPartial(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            // API çağrısından dönen değer
            var values = await _productDetailService.GetByProductIdProductDetailAsync(id);

            // Eğer null ise boş bir model gönder
            if (values == null)
            {
                values = new GetByIdProductDetailDto(); // veya default değerler ile doldur
            }

            return View(values);
        }
    }
}
