namespace POSFrontendBlazor.Services
{
    public static class EndPoints
    {
        public static string ProductCategory { get; } = "ap1/v1/product-category";
        public static string WithPagination(this string url, int pageNo, int pageSize)
        {
            return $"{url}/{pageNo}/{pageSize}";
        }
    }
}
