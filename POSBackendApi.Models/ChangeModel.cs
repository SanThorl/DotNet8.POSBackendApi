using POSBackendApi.DbServices.Models;
using POSBackendApi.Models.Setup.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSBackendApi.Models;

public static class ChangeModel
{
    public static ProductCategoryModel Change(this TblProduct Category dataModel)
    {
        var model = new ProductCategoryModel()
        {
            ProductCategoryId = dataModel.ProductCategoryId,
            ProductCategoryCode = dataModel.ProductCategoryCode,
            ProductCategoryName = dataModel.ProductCategoryName
        };
        return model;
    }
}

