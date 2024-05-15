namespace POSFrontendBlazor.Models
{
    public class ResponseModel
    {
        public string Token { get; set; }
        public int Result { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsError { get { return !IsSuccess; } }
    }
}
