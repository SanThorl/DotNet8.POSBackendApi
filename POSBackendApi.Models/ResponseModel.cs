﻿using Newtonsoft.Json.Linq;
using POSBackendApi.Models.Setup.ProductCategory;

namespace POSBackendApi.Models;

public class ResponseModel
{
    public object Return(ReturnModel model)
    {
        JObject jsonObject = new JObject(
            new JProperty("message", model.Message),
            new JProperty("token", model.Token),
            new JProperty("isSuccess", model.IsSuccess),
            new JProperty("data", model.Item is null ? model.Item : new JObject(
                    new JProperty(model.EnumPos.ToString().ToLower(), JToken.FromObject(model.Item))
                )
            )
        );
        if (model.Count is not null)
        {
            jsonObject.Add(new JProperty("result", model.Count));
        }
        if (model.PageSetting is not null)
        {
            jsonObject.Add(new JProperty("pageSetting", JToken.FromObject(model.PageSetting)));
        }
        return jsonObject;
    }
}

    public class ReturnModel
    {
        public string Token { get; set; }
        public string Message { get; set; }
        public int? Count { get; set; }
        //public EnumPos EnumPos { get; set; }
        public bool IsSuccess { get; set; }
        public object? Item { get; set; }
        public PageSettingModel PageSetting { get; set; }
    }
