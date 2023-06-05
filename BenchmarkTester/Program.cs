// See https://aka.ms/new-console-template for more information
using BenchmarkDemo.BenchmarkExecutors;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<WeatherBenchmarkExecutor>();
