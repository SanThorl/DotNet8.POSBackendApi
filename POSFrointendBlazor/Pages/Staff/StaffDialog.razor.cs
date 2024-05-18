using POSFrontendBlazor.Models.Staff;

namespace POSFrontendBlazor.Pages.Staff
{
    public partial class StaffDialog
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }

        private StaffRequestModel reqModel = new();

        private void Cancel()
        {
            MudDialog.Cancel();
        }

        private async Task SaveAsync()
        {
            DateTime StaffDOB = reqModel.DateOfBirth;
            DateTime DateTimeNow = DateTime.Now;
            TimeSpan ageSpan = DateTimeNow - StaffDOB;
            int StaffAge = (int)(ageSpan.Days / 365.25);
            if (StaffAge < 18)
            {
                InjectService.ShowMessage("Staff's age must be greater than 18.", EnumResponseType.Warning);
            }
            else
            {
                var response = await HttpClientService.ExecuteAsync<StaffResponseModel>(
                    EndPoints.Staff,
                    EnumHttpMethod.Post,
                    reqModel);

                if (response.IsError)
                {
                    Console.WriteLine(response.Message);
                    //Console.WriteLine(EnumResponseType.Error);
                    InjectService.ShowMessage(response.Message, EnumResponseType.Error);
                    return;
                }
                InjectService.ShowMessage(response.Message, EnumResponseType.Success);
                MudDialog.Close();
            }

        }
    }
}
