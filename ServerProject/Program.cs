using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAddress = IPAddress.Parse("192.168.56.1");

            IPAddress[] addresses = Dns.GetHostAddresses("microsoft.com");

            string str = "";
            foreach (IPAddress address in addresses)
            {
                str += address + "\t";
            }

            IPEndPoint endPoint = new IPEndPoint(ipAddress, 1024);

            Socket pass_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            
            pass_socket.Bind(endPoint);
            pass_socket.Listen(10);

            Console.WriteLine("Server started at port 1024");
            try
            {
                while(true)
                {
                    Socket ns = pass_socket.Accept();

                    Console.WriteLine($"Client {ns.LocalEndPoint} was connected");
                    Console.WriteLine($"Client {ns.RemoteEndPoint} was connected");

                    ns.Send(Encoding.Default.GetBytes($"Server {ns.LocalEndPoint} send answer {DateTime.Now}\n, adresses microsoft: {str}\n The Address Family - {ns.AddressFamily}"));

                    ns.Shutdown(SocketShutdown.Both);
                    ns.Close();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


        }
    }
}
