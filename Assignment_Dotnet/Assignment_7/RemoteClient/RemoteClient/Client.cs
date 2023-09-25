using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteServer;

namespace RemoteClient
{
    class Client
    {
        static void Main(string[] args)
        {
            TcpChannel tcp_channel1 = new TcpChannel(8098);   //1.creting client channel
            //2. register the channel
            ChannelServices.RegisterChannel(tcp_channel1);
             //3. create a service class object

            Service service_obj = (Service)Activator.GetObject(typeof(Service), "tcp://localhost:89/CreatingEmployeeCredentials");
            //4 call the service functions of employee credentials
            Service.Details();
            Service.GenerateMailid();
            Console.ReadLine();
        }
    }
}
