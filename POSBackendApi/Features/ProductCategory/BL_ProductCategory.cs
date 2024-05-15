using POSFrontendBlazor.Models;
using POSFrontendBlazor.Models.ProductCategory;

namespace POSBackendApi.Features.ProductCategory;

public class BL_ProductCategory
{
    private readonly DL_ProductCategory _ProductCategory;

    public BL_ProductCategory(DL_ProductCategory productCategory)
    {
        _ProductCategory = productCategory;
    }

    public async Task<ProductCategoryListResponseModel> GetProductCategory()
    {
        var response = await _ProductCategory.GetProductCategory();
        return response;
    }
} 
