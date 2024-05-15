
namespace POSFrontendBlazor.Pages.ProductCategory;

public partial class P_ProductCategoryDialog
{
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    private ProductCategoryRequestModel reqModel = new();

    private void Cancel()
    {
        MudDialog.Cancel();
    }

    private async Task SaveAsync()
    {
        var response = await HttpClientService.ExecuteAsync<ProductCategoryResponseModel>(
            EndPoints.ProductCategory,
            EnumHttpMethod.Post,
            reqModel
        );

        if (response.IsError)
        {
            return;
        }

        MudDialog.Close();
    }
}
