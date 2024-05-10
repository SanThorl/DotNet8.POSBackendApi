using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSBackendApi.DbServices
{
    public partial class TblProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string ProductCategoryCode { get; set; }
        public string ProductCategoryName { get; set; }
    }
}
