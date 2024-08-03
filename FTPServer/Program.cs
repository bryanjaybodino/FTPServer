
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FTPServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int port = 2022;
            string directory = "C://";

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties properties = ni.GetIPProperties();
                    foreach (UnicastIPAddressInformation ip in properties.UnicastAddresses)
                    {
                        Console.WriteLine("ftp://"+ip.Address.ToString()+":"+port);
                    }
                }
            }

       
            Commands commands = new Commands(directory, port);
            await commands.StartAsync();
        }
    }
}
