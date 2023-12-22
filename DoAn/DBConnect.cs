using System;
using System.Data;
using System.Data.SqlClient;

namespace DoAn
{
    class DBConnect
    {
        private static string stringConnection = @"Data Source=LAPTOP-GSL3DJO2;Initial Catalog= DDSV_Last;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

        SqlConnection connect;

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }

        public DBConnect()
        {
            connect = new SqlConnection(stringConnection);
        }

        public void open()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }

        public void close()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }

        public int getNonQuery(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            int kq = cmd.ExecuteNonQuery();
            close();
            return kq;
        }

        public SqlDataReader getDataReader(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }

        public object getScalar(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            object kq = cmd.ExecuteScalar();
            close();
            return kq;
        }

        public DataTable getDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }

        public int updateDatabase(string sql, DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }

        public int executeNonQuery(string sql)
        {
            int rowsAffected = 0;

            try
            {
                open();
                SqlCommand query = new SqlCommand(sql, connect);
                rowsAffected = query.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }
            finally
            {
                close();
            }

            return rowsAffected;
        }
    }
}
