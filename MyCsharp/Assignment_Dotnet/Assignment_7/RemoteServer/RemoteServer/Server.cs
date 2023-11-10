using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemoteServer
{
    public class Service : MarshalByRefObject
    {
        static string Fname, Lname;
        static string Mail = " ";
        static int EmployeeId = 0;
        public static void Details()
        {
            Console.WriteLine("enter the details of Employee");
            Console.Write("enter First name: ");
            Fname = Console.ReadLine();
            Console.Write("enter Lastname: ");
            Lname = Console.ReadLine();
            Console.WriteLine($"name of the employee is: {Fname} {Lname}");
        }
        public static void GenerateMailid()
        {
            Mail = Fname + Lname.Substring(0, 2) + "@infinite.com";
            Random random = new Random();
            EmployeeId = random.Next(1000000, 9999999);
            Console.WriteLine($"The Mail id and EmployeeId of {Fname} {Lname} is: \n Email Id: {Mail.ToLower()} \n Employee Id: {EmployeeId}");

        }

    }
    class Server
    {
        static void Main(string[] args)
        {
            TcpChannel tcp_channel = new TcpChannel(89);//creating channel
            ChannelServices.RegisterChannel(tcp_channel);//registering channel
            //configure all known services
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "CreatingEmployeeCredentials", WellKnownObjectMode.Singleton);
            Console.WriteLine("server for employee credentials has started ");
            Console.WriteLine("enter x to stop the server");
            Console.ReadLine();

        }
    }
}
