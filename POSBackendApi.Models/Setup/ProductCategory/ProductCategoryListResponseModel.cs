namespace POSBackendApi.Models.Setup.ProductCategory;

public class ProductCategoryListResponseModel : ResponseModel
{
    public List<ProductCategoryModel> DataList { get; set; }
    public ProductCategoryDataModel Data { get; set; }

}
public class ProductCategoryDataModel
{
    //public PageSettingModel PageSetting { get; set; }
    public List<ProductCategoryModel> ProductCategory { get; set; }
}
