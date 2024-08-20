using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class dbCon
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-06GENJD\SQLEXPRESS;Initial Catalog=db1;Integrated Security=True;");

        // SqlConnection con = new SqlConnection(@"Data Source=CS-LAB1-27\SQLEXPRESS;Initial Catalog=officemsystemdb;Integrated Security=True;");

        public bool UDI(String query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int c = cmd.ExecuteNonQuery();
                if (c > 0)
                    return true;
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Search(String query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //data structure reside in ram db reside in hard Disk
            return dt;
        }
        public int getIntNumber(String query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteScalar();
                int maxReceiptNumber = 0;
                if (result != DBNull.Value)
                {
                    maxReceiptNumber = Convert.ToInt32(result);
                }
                return maxReceiptNumber;
            }
                catch(Exception ex)
                    {
                        return 0;
            }
            finally { con.Close(); }


            
        }

        public bool ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(procedureName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ExecuteStoredProcedureWithDataTable(string procedureName, SqlParameter[] parameters)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(procedureName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }


    }
}
