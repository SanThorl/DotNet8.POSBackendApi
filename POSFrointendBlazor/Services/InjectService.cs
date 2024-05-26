using Microsoft.JSInterop;

namespace POSFrontendBlazor.Services;

public class InjectService
{
    private readonly ISnackbar _snackbar;
    private readonly JSRuntime _jsRuntime;

    public InjectService(ISnackbar snackbar)
    {
        _snackbar = snackbar;
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
