using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARPOS
{
    internal class DatabaseHelper
    {
        //Veritabanı bağlantı cümlesi
        private static readonly string connectionString =
            "Data Source=LAPTOP-DPND1RVT\\SQLEXPRESS02;Initial Catalog=RandevuSistemi;Integrated Security=True;TrustServerCertificate=True";

        //Bağlantı nesnesi oluşturma
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // 1) INSERT / UPDATE / DELETE → ExecuteNonQuery
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("SQL Hatası: " + ex.Message);
                return -1;
            }
        }

        // 2) SELECT → ExecuteSelect
        public static DataTable ExecuteSelect(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("SQL Hatası: " + ex.Message);
                return null;
            }
        }

        // 3) Tek sonuç döndüren sorgular → ExecuteScalar    
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("SQL Hatası: " + ex.Message);
                return null;
            }
        }
    }
}
