// See https://aka.ms/new-console-template for more information
using BenchmarkDemo.BenchmarkExecutors;
using BenchmarkDemo.DapperDataAccess;
using BenchmarkDotNet.Running;

//DataAccess dataAccess = new DataAccess();
//var users=dataAccess.GetUsers();
//Console.WriteLine(users);
//BenchmarkRunner.Run<WeatherBenchmarkExecutor>();
BenchmarkRunner.Run<EfcoreVsDapperBenchmarkExecutor>();
