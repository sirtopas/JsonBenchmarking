﻿using BenchmarkDotNet.Running;

namespace JsonBenchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<JsonBenchmarks>();
        }
    }
}
