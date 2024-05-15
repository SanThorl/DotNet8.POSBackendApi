using Microsoft.AspNetCore.Mvc;
using POSFrontendBlazor.Models;


namespace POSBackendApi.Features.ProductCategory;
[Route("api/v1/product-categories")]
[ApiController]
public class ProductCategoryController : BaseController
{
    private readonly BL_ProductCategory _productCategory;
    private readonly ResponseModel _response;

    public ProductCategoryController(IServiceProvider serviceProvider, BL_ProductCategory productCategory, ResponseModel response) : base(serviceProvider)
    {
        _productCategory = productCategory;
        _response = response;
    }

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
                    Token = RefreshToken(),
                    Count = lst.DataList.Count,
                    EnumPos = EnumPos.ProductCategory,
                    IsSuccess = lst.MessageResponse.IsSuccess,
                    Message = lst.MessageResponse.Message,
                    Item = lst.DataList
                });
            return Content(model);
        }
        catch(Exception ex)
        {
            return InternalServerError(ex);
        }
    }

    public async Task<IActionResult> Create(ProductCategoryModel _requestModel)
    {
        try
        {
            var item = await _productCategory.CreateProductCategory(requestModel);
            var model = _response.Return(new ReturnModel
            {
                Token = RefreshToken(),
                EnumPos = EnumPos.ProductCategory,
                IsSuccess = item.IsSuccess,
                Message = item.Message,
                Item = requestModel
            });
            return Content(model);
        }
        catch(Exception ex)
        {
            return InternalServerError(ex);
        }
    }
}
