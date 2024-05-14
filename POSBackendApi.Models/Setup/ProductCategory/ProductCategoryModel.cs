using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSBackendApi.Models.Setup.ProductCategory
{
    public class ProductCategoryModel
    { 
        public int ProductCategoryId { get; set; }
        public string? ProductCategoryCode { get; set; } = null!;
        public string? ProductCategoryName { get; set; } = null!;
    }
}
