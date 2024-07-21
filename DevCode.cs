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
		var settings = new JsonSerializerSettings { DateFormat}
	result:
		return result;
	}
	
}
