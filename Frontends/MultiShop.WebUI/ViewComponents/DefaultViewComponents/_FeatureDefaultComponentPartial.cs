using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.FeatureServices;
using MultiShop.DtoLayer.Dtos.CatalogDtos.FeatureDtos;

namespace MultiShop.WebUI.ViewComponents.DefaultViewComponents
{
    public class _FeatureDefaultComponentPartial : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _FeatureDefaultComponentPartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // WebUI.Services tarafındaki IFeatureService'i kullanıyoruz
            var values = await _featureService.GetAllFeatureAsync();
            return View(values); // Views/Shared/Components/_FeatureDefaultComponentPartial/Default.cshtml
        }
    }
}
