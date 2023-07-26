using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace CDIO4
{
    public class Table
    {
        public int ID { get; set; }
        public string TenBan { get; set; }
        public string TinhTrang { get; set; }
        public Table()
        {

        }
    }

    class ClassChung
    {
        SqlConnection conn;
        public ClassChung()
        {
            // khai báo chuỗi kết nối
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+"\\Database.mdf;Integrated Security=True";
        }


        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public bool TimKiem(string sql)
        {
            bool kq = false;
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                kq = true;
            }
            reader.Close();
            conn.Close();
            return kq;
        }

        public object Scalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //load table for usercontrol
        public List<TableUserControl> GetTableUserControlsFromDatabase()
        {
            String sql = "SELECT ID, TENBAN, TINHTRANG FROM BAN";
            List<TableUserControl> tableUserControls = new List<TableUserControl>();

            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    TableUserControl tableUserControl = new TableUserControl();
                    tableUserControl.UpdateTableInfo(
                        Convert.ToInt32(reader["ID"]),
                        reader["TENBAN"].ToString(),
                        reader["TINHTRANG"].ToString()
                    );
                    tableUserControls.Add(tableUserControl);
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tableUserControls;
        }

    }

}
