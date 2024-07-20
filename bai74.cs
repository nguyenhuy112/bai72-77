. Câu lệnh chèn dữ liệu vào 1 bảng của CSDL SQLS.
Sửa, Tạo CSDL và chạy code như sau:
using System;
using System.Data.SqlClient;
namespace Database_Operation
{
    class InsertStatement
    {
        static void Main()
        {
            Insert();
            Console.ReadKey();
        }

        static void Insert()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=DESKTOP-GP8F496;Initial Catalog=Demodb;User ID=sa;Password=24518300";
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();
            string sql = "";
            sql = "insert into demo values(3, 'Python')";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}