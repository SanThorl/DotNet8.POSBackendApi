using Microsoft.AspNetCore.Mvc;

namespace POSBackendApi.Features.ProductCategory
{
    public class ProductCategoryController : Controller
    {
        private readonly BL_ProductCategory _productCategory;
        private readonly ResponseModel _response;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetProductCategory()
        {
            try
            {
                var lst = await _productCategory.GetProductCategory();
                var model = _response.Return
                    (new ReturnModel
                    {

                    });
                return Content(model);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
