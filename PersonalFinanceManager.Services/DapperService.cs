using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using Newtonsoft.Json;

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

        public List<T> QueryStoredProcedure<T>(string query, object param = null)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var lst = db.Query<T>(query, param, commandType: CommandType.StoredProcedure);
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

        public DataTable QueryDataTable(string query, List<SqlParameter> parameters = null)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            return dt;
        }

        public DataTable QueryDataTableStoredProcedure(string query, List<SqlParameter> parameters = null)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            return dt;
        }
    }
}
