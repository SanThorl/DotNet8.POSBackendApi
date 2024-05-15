using POSBackendApi.Models.Setup.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSBackendApi.Models;

public static class ChangeModel
{
    public static ProductCategoryModel Change(this TblProductCategories DbData)
    {
        DbData.ProductCategoryCode
    }
}
