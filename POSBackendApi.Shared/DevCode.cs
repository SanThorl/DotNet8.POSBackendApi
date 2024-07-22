
public static class DevCode
{
	#region Object To Json
	public static string? ToJson<T>(this T? obj, bool format = false)
	{
		if (obj == null) return string.Empty;
		string? result;
		if (obj is string)
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
	#endregion

	#region Skip&Take for Pagination
	public static IQueryable<TSource> Pagination<TSource>(this IQueryable<TSource> source, int pageNo, int pageSize)
	{
		return source.Skip((pageNo - 1) * pageSize).Take(pageSize);
	} 
	#endregion

	public static DateTime ToDateTime(this DateTime? dateTime)
	{
		return Convert.ToDateTime(dateTime);
	}

	public static string ToHash(this string password, string sharedKey)
	{
		return Hash.Create(HashType.SHA256, password, sharedKey, false);
	}
}
