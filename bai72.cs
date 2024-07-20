create database Demodb;
use Demodb;
CREATE TABLE demo(
    articleID varchar(30) NOT NULL PRIMARY KEY,
    articleName varchar(30) NOT NULL
);
insert into demo values('1', 'C#');
insert into demo values('2', 'C++');
// C# code to connect the database
using System;
using System.Data.SqlClient;

namespace Database_Operation
{
    class DBConn
    {
        // Main Method
        static void Main()
        {
            Connect();
            Console.ReadKey();
        }

        static void Connect()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=DESKTOP-GP8F496;Initial Catalog=Demodb;User ID=sa;Password=24518300";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Mở kết nối!");

            // Đóng kết nối
            conn.Close();
        }
    }
}