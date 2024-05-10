using Microsoft.AspNetCore.Mvc;

namespace POSBackendApi.Features.ProductCategory
{
    public class ProductCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
