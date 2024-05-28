using POSBackendApi.DbServices.Models;
using POSBackendApi.Models.Setup.ProductCategory;
using POSBackendApi.Models.Setup.Staff;

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

    #region
    public static StaffModel Change(this TblStaff dataModel)
    {
        var staffModel = new StaffModel()
        {
            StaffId = dataModel.StaffId,
            StaffCode = dataModel.StaffCode,
            StaffName = dataModel.StaffName,
            DateOfBirth = dataModel.DateOfBirth,
            MobileNo = dataModel.MobileNo,
            Address = dataModel.Address,
            Gender = dataModel.Gender,
            Position = dataModel.Position,
            Password = dataModel.Password
        };
        return staffModel;
    }

    public static TblStaff Change(this StaffModel dataModel)
    {
        var staffModel = new TblStaff()
        {
            StaffId = dataModel.StaffId,
            StaffCode = dataModel.StaffCode,
            StaffName = dataModel.StaffName,
            DateOfBirth = dataModel.DateOfBirth,
            MobileNo = dataModel.MobileNo,
            Address = dataModel.Address,
            Gender = dataModel.Gender,
            Position = dataModel.Position,
            Password = dataModel.Password
        };
        return staffModel;
    }
    #endregion
}

