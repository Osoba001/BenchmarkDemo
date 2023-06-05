using BenchmarkDemo.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BenchmarkDemo.DapperDataAccess
{
    public class DataAccess
    {

        public User[] GetUsers()
        {
            using var con = new SqlConnection("Data Source=.;Initial Catalog=BenchmarkDb;Integrated Security=True; Encrypt=False");
            con.Open();
            return con.Query<User>(@"select * from [dbo].[User]").ToArray();
        }
    }
}
