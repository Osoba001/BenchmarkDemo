using BenchmarkDemo.Controllers;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDemo.BenchmarkExecutors
{
    public class WeatherBenchmarkExecutor
    {
        [Benchmark]
        public void Exeute()
        {
            var weatherCtl = new WeatherForecastController(null);
            weatherCtl.Get();
        }
    }
}
