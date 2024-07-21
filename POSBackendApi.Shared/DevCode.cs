using Newtonsoft.Json;
using System;

public static class DevCode
{
	public static string? ToJson<T>(this T? obj, bool format = false)
	{
		if (obj == null) return string.Empty;
		string? result;
		if(obj is string)
		{
			result = obj.ToString();
			goto Result;
		}
		var settings = new JsonSerializerSettings { DateFormatString = "yyyy-MM-ddTHH:mm:ss.sssZ" };
		result = format
			? JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented, settings)
			: JsonConvert.SerializeObject(obj, settings);

    Result:
		return result;
	}
	
}
