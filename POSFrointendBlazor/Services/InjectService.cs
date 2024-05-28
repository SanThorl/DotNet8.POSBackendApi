using Microsoft.JSInterop;
using POSFrontendBlazor.Pages.Staff;

namespace POSFrontendBlazor.Services;

public class InjectService
{
    private readonly ISnackbar _snackbar;
    private readonly JSRuntime _jsRuntime;
    private readonly IDialogService _dialogService;

    public InjectService(ISnackbar snackbar, JSRuntime jsRuntime, IDialogService dialogService)
    {
        _snackbar = snackbar;
        _jsRuntime = jsRuntime;
        _dialogService = dialogService;
    }

    public void ShowMessage(string message, EnumResponseType responseType)
    {
        switch (responseType)
        {
            case EnumResponseType.Success:
                _snackbar.Add(message, Severity.Success);
                break;
            case EnumResponseType.Information:
                _snackbar.Add(message, Severity.Info);
                break;
            case EnumResponseType.Warning:
                _snackbar.Add(message, Severity.Warning);
                break;
            case EnumResponseType.Error:
                _snackbar.Add(message, Severity.Error);
                break;
            default:
                break;
        }
    }

    public async Task<DialogResult> ShowModelBoxAsync<T>(string title) where T : IComponent
    {
        MudBlazor.DialogOptions options = new MudBlazor.DialogOptions()
        {
            MaxWidth = MaxWidth.Small,
            FullWidth = true,
            DisableBackdropClick = true,
            CloseOnEscapeKey = false
        };
        var dialog = await _dialogService.ShowAsync<StaffDialog>("New Staff", options);
        var result = await dialog.Result;
        return result;
    }
    public async Task EnableLoading()
    {
        await _jsRuntime.InvokeVoidAsync("enableLoading", true);
    }

    public async Task DisableLoading()
    {
        await _jsRuntime.InvokeVoidAsync("enableLoading", false);
    }
}
public enum EnumResponseType
{
    Success,
    Information,
    Warning,
    Error
}
