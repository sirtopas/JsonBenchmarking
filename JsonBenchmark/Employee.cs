using System.Collections.Generic;

namespace JsonBenchmark
{
    public class Employee
    {
        public int FileId { get;  set; }

        public string Username { get; set; }

        public IEnumerable<string> Roles { get; set; }
    }
}
