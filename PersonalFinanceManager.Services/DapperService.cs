using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;

namespace PersonalFinanceManager.Services
{
    public class DapperService
    {
        private readonly string _connectionString;

        public DapperService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        }

        public T QueryFirstOrDefault<T>(string query, object param = null, CommandType commandType = CommandType.Text)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var item = db.QueryFirstOrDefault<T>(query, param, commandType: commandType);
                return item;
            }
        }

        public List<T> Query<T>(string query, object param = null, CommandType commandType = CommandType.Text)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var lst = db.Query<T>(query, param, commandType: commandType);
                return lst.ToList();
            }
        }

        public int Execute(string query, object param = null, CommandType commandType = CommandType.Text)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var result = db.Execute(query, param, commandType: commandType);
                return result;
            }
        }
    }
}
