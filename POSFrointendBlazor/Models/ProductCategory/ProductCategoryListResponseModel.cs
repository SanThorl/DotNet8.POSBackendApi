namespace POSFrontendBlazor.Models.ProductCategory
{
    public class ProductCategoryListResponseModel : ResponseModel
    {
        public ProductCategoryDataModel Data { get; set; }
        public PageSetting PageSetting { get; set; }
    }
}
