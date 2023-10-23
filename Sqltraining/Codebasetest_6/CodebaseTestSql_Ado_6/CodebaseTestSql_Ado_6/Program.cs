using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CodebaseTestSql_Ado_6
{
    class Program
    {
        public static SqlConnection conn;
        public static SqlCommand comm;
        public static SqlDataReader dr;
       
        static void Main(string[] args)
        {
            Insertdata();
            Displaydata();
            Console.Read();

        }
        static SqlConnection ToGetConnection()
        {
            //
            conn = new SqlConnection("Server=ICS_LAP_7347 ;Database=SqlAmar; Integrated Security=True ");
            conn.Open();
            return conn;
        }

        public static void Insertdata()
        {
            conn = ToGetConnection();
            Console.WriteLine("enter the values of empname,empsal,emptype");
           
            string ename= Console.ReadLine();
            int esal = Convert.ToInt32(Console.ReadLine());
            char etype = Convert.ToChar(Console.ReadLine());
            comm = new SqlCommand("AddRecord @empname,@empsal,@emptype", conn);
            comm.Parameters.AddWithValue("@empname", ename);
            comm.Parameters.AddWithValue("@empsal", esal);
            comm.Parameters.AddWithValue("@emptype", etype);
            int ins = comm.ExecuteNonQuery();
            if (ins > 0)
                Console.WriteLine("Record got Inserted");
            else
                Console.WriteLine("Record Not Inserted..");

        }
        public static void Displaydata()
        { 
            
              
                conn = ToGetConnection();
                comm = new SqlCommand("select * from tblemployee");
                comm.Connection = conn;
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Employee number :" + " " + dr[0]);
                    Console.WriteLine("Employee Name :" + " " + dr[1]);
                    Console.WriteLine("Employee Salary :" + " " + dr[3]);
                Console.WriteLine("Employee Type :" + " " + dr[4]);
                }

            
        }
    
       
    }
}
