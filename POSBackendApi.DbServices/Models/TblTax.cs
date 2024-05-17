using System;
using System.Collections.Generic;

namespace POSBackendApi.DbServices.Models;

public partial class TblTax
{
    public int TaxId { get; set; }

    public int FromAmount { get; set; }

    public int ToAmount { get; set; }

    public decimal Percentage { get; set; }
}
