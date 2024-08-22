using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAL
    {
        public SqlConnection cn;
        public SqlCommand cmd;
        private string connectionString;

        public DAL(string cnString)
        {
            connectionString = cnString;
            cn = new(connectionString);
        }

        public void Open()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();
        }

        public void Close()
        {
            if (cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }

        public void SetSql(string sqlStatement)
        {
            cmd = new(sqlStatement, cn);
        }

        public void addParameters(string parameterName, object parameterVal)
        {
            cmd.Parameters.AddWithValue(parameterName, parameterVal);
        }

        public void clearParameters()
        {
            cmd.Parameters.Clear();
        }

        public void Execute(bool autoConnect = false)
        {
            if (autoConnect == true)
            {
                Open();
                cmd.ExecuteNonQuery();
                Close();
            }
            if (!(autoConnect == true))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable retrieveData(bool autoConnect = false)
        {
            SqlDataAdapter da = new(cmd);
            DataTable dt = new();

            if (autoConnect == true) Open();
            da.Fill(dt);
            if (!(autoConnect == true)) Close();
            return dt;
        }
    }
}
