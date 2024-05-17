using POSFrontendBlazor.Models;
using POSFrontendBlazor.Models.ProductCategory;

namespace POSBackendApi.Features.ProductCategory;

public class BL_ProductCategory
{
    private readonly DL_ProductCategory _productCategory;

    public BL_ProductCategory(DL_ProductCategory productCategory)
    {
        _productCategory = productCategory;
    }

    public async Task<ProductCategoryListResponseModel> GetProductCategory()
    {
        var response = await _productCategory.GetProductCategory();
        return response;
    }

    public async Task<ProductCategoryListResponseModel> GetProductCategory(int pageNo, int pageSize)
    {
        return await _productCategory.GetProductCategory(pageNo, pageSize);
    }
} 
