using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace PersonalFinanceManager
{
    internal class DB
    {
        internal static string constring = PersonalFinanceManager.Properties.Settings.Default.Constring;
        internal static SqlDataAdapter da;
        internal static string sql { get; set; }
        internal static DataSet ds;
        internal static DataTable dt;
        internal static SqlCommand cmd;
        internal static SqlDataReader dr;

        public static DataSet LoadUsers()
        {
            SqlConnection con = new SqlConnection(constring);
            ds = new DataSet();
            try
            {
                con.Open();               
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public static DataTable Login(string username, string password)
        {
            SqlConnection con = new SqlConnection(constring);
            dt = new DataTable();
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                dt.Dispose();
            }
            return dt;
        }

        public static DataTable GetDataTable()
        {
            SqlConnection con = new SqlConnection(constring);
            dt = new DataTable();
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                dt.Dispose();
            }
            return dt;
        }
        
        public static void DoInsert(string message,out int insertedId)
        {
            SqlConnection con = new SqlConnection(constring);
            insertedId = -1; // Default value for the inserted ID
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                // Add an output parameter to retrieve the inserted ID
                SqlParameter param = new SqlParameter("@InsertedId", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                insertedId = (int)cmd.Parameters["@InsertedId"].Value; // Retrieve the inserted ID
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static SqlDataReader GetDataReader()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataReader dr = null;
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dr;
        }
        
        public static SqlDataReader InsertTitles(string nextsql)
        {
            SqlConnection con = new SqlConnection(constring);
            dt = new DataTable();
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(nextsql, con);
                dr = cmd.ExecuteReader();             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dr;
        }

        public static int CheckBalanceAndBudget(out int StatusCode)
        {
            SqlConnection con = new SqlConnection(constring);
            StatusCode = -1;
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                SqlParameter statusCodeParam = new SqlParameter("@StatusCode", SqlDbType.Int);
                statusCodeParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(statusCodeParam);

                cmd.ExecuteNonQuery();
                StatusCode = (int)cmd.Parameters["@StatusCode"].Value;
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return StatusCode;
        }

        public static DataSet GetDataSet()
        {
            SqlConnection con = new SqlConnection(constring);
            ds = new DataSet();
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if(ds.Tables.Count>0)
                {
                    return ds;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static void DoInsertSaving(out int StatusCode, out int InsertedId)
        {
            SqlConnection con = new SqlConnection(constring);
            InsertedId = 0;
            StatusCode = -1;
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@StatusCode", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@InsertedId", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@StatusCode"].Value != DBNull.Value)
                {
                    StatusCode = (int)cmd.Parameters["@StatusCode"].Value;
                }

                if (cmd.Parameters["@InsertedId"].Value != DBNull.Value)
                {
                    InsertedId = (int)cmd.Parameters["@InsertedId"].Value;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
            