using System.Collections.Generic;
using System.Text.Json;

namespace JsonBenchmark
{
    public class JsonParser
    {
        public List<Employee> SystemTextJsonParseJson(string jsonString)
        {
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize< List<Employee>>(jsonString, options);
        }

        public List<Employee> NewtonSoftParseJson(string jsonString)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(jsonString);
        }
    }
}
