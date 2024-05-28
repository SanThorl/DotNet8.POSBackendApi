using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSFrontendBlazor.Models.Custom;

public class StaticData
{
    public static List<KeyValueModel> Gender()
    {
        return new List<KeyValueModel>()
        {
            new KeyValueModel("0", "--Select One--"),
             new KeyValueModel("Male", "Male"),
             new KeyValueModel("Female", "Female")
        };
    }
}

public class KeyValueModel
{
    public string Key { get; set; }
    public string Value { get; set; }

    public KeyValueModel(string key, string value)
    {
        Key = key;
        Value = value;
    }
}
