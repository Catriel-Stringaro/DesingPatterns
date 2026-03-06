using System.Text.Json;

namespace Prototype
{
    public static class ExtentionMethod
    {
        public static T DeepCopy<T>(this T self)
        {
            var options = new JsonSerializerOptions { IncludeFields = true };
            var json = JsonSerializer.Serialize(self, options);
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}
