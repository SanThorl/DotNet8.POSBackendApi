namespace POSFrontendBlazor.Models
{
    public class ResponseModel
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsError { get { return !IsSuccess; } }
    }
}
