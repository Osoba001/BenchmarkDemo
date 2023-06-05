using BenchmarkDemo.Controllers;
using BenchmarkDemo.DapperDataAccess;
using BenchmarkDemo.EfcoreDataAcess;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDemo.BenchmarkExecutors
{
    public class EfcoreVsDapperBenchmarkExecutor
    {
        [Benchmark]
        public void ExecuteEfcore()
        {
            var userCtr = new UsersController();
         var users=   userCtr.GetUser();
        }[Benchmark]
        public void ExecuteDapper()
        {
            var userCtr = new DataAccess();
         var users=   userCtr.GetUsers();
        }
    }
}
