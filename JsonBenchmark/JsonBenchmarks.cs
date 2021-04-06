using System.IO;
using BenchmarkDotNet.Attributes;

namespace JsonBenchmark
{
    [MemoryDiagnoser]
    public class JsonBenchmarks
    {
        private string _jsonString = File.ReadAllText("employee-data.json");
        private static readonly JsonParser _parser = new();

        [Benchmark]
        public void SystemTextJson()
        {
            _parser.SystemTextJsonParseJson(_jsonString);
        }

        [Benchmark (Baseline =true)]
        public void NewtonSoftJson()
        {
            _parser.NewtonSoftParseJson(_jsonString);
        }
    }
}
