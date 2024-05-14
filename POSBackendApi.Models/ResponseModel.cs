namespace POSBackendApi.Models
{
    public class ResponseModel
    {

    }
    public class ReturnModel
    {
        public string Token { get; set; }
        public string Message { get; set; }
        public int? Count { get; set; }
        //public EnumPos EnumPos { get; set; }
        public bool IsSuccess { get; set; }
        public object? Item { get; set; }
        //public PageSettingModel PageSetting { get; set; }
    }
}
