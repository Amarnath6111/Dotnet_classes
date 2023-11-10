using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOConnection
{
    class ADOUpdate
    {
        public static SqlConnection conn;
        public static SqlCommand comm;
        public static SqlDataReader reader;

        public static SqlConnection GetConnection()
        {
            conn = new SqlConnection("Data Source=ICS_LAP_7347;Initial Catalog=infiniteDB;Integrated Security= True");
            conn.Open();
            return conn;

        }
        public static void UpdateRecord()
        {
            GetConnection();
            Console.Write("enter the Employee id to Update salary: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("enter the amount to update: ");
            int amount= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            comm = new SqlCommand("update tblEmp set  salary=salary+@amount from tblEmp where empid=@empid", conn);
            comm.Parameters.AddWithValue("@amount", amount);
            comm.Parameters.AddWithValue("@empid", id);
            int r = comm.ExecuteNonQuery();
            if(r>0)
            {
                Console.WriteLine("updated");
            }
            else
            {
                Console.WriteLine("not updated");
            }

        }
        static void SelectData()
        {
            conn = GetConnection();
            SqlCommand comm = new SqlCommand("select * from tblEmp");
            comm.Connection = conn;
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + " "+reader[1] +" "+reader[2]+" "+reader[3]+" "+reader[4]);

            }
        }
        static void Main(string[] args)
        {
            SelectData();
            UpdateRecord();
            SelectData();
            Console.Read();
        }
    }
}
