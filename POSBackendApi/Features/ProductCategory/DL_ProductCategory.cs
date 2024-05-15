using Microsoft.EntityFrameworkCore;
using POSFrontendBlazor.Models.ProductCategory;

namespace POSBackendApi.Features.ProductCategory
{
    public class DL_ProductCategory
    {
        private readonly AppDbContext _context;

        public DL_ProductCategory(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ProductCategoryListResponseModel> GetProductCategory()
        {
            var responseModel = new ProductCategoryListResponseModel();
            try
            {
                var lst = await _context.TblProductCategories.AsNoTracking().ToListAsync();

                responseModel.DataList(lst)
            }
        }
    }
}
