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
    #region Product Category
    public static ProductCategoryModel Change(this TblProductCategory dataModel)
    {
        var model = new ProductCategoryModel()
        {
            ProductCategoryId = dataModel.ProductCategoryId,
            ProductCategoryCode = dataModel.ProductCategoryCode,
            ProductCategoryName = dataModel.ProductCategoryName
        };
        return model;
    }

    public static TblProductCategory Change(this ProductCategoryModel dataModel)
    {
        var model = new TblProductCategory() {
            ProductCategoryId = dataModel.ProductCategoryId,
            ProductCategoryCode= dataModel.ProductCategoryCode,
            ProductCategoryName = dataModel.ProductCategoryName
        };
        return model;
    }
    #endregion
}

