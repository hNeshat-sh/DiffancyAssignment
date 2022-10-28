using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DiffancyAssignment.Services
{
    public static class Serializer
    {

        static JsonSerializerSettings jsonSerializerSettings => new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            },
            Formatting = Newtonsoft.Json.Formatting.Indented
        };

        public static string JsonSerialize(object value)
        {
            return JsonConvert.SerializeObject(value, jsonSerializerSettings);
        }

        public static T JsonDeSerialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value, jsonSerializerSettings);
        }

    }
}