using System.Diagnostics;
using System.Net.Mime;
using System.Net.NetworkInformation;
using System.Text;

namespace Systemabfrage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MachineName = Environment.MachineName;
            string Username = Environment.UserName;
            string OSVersion = Environment.OSVersion.ToString();
            string UserDomainName = Environment.UserDomainName;


            Console.WriteLine("Current MachineName: " + MachineName);
            Console.WriteLine("Current Username: " + Username);
            Console.WriteLine("Current OSVersion: " + OSVersion);
            Console.WriteLine("Current UserDomainName: " + UserDomainName);

        }
    }
}
