using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Socket_Programming
{
    class Cilent_Sychronous_Socket
    {
        public static void StartClient()
        {
            byte[] bytes = new byte[1024];

            try

            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteep= new IPEndPoint(ipAddress, 11000);

                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect (remoteep);
                    Console.WriteLine("Socket Connected to {0}", sender.RemoteEndPoint.ToString());

                    byte[] msg = Encoding.ASCII.GetBytes("This is Socket Programming");
                    int bytesent = sender.Send(msg);

                    int byteReceive = sender.Receive(msg);
                    Console.WriteLine("received{0}", Encoding.ASCII.GetString(bytes, 0, byteReceive));

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }

                catch (ArgumentNullException an)
                {
                    Console.WriteLine("ArgumentNullException:{0}", an.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException:{0}", se.ToString());

                }
                catch (Exception e)
                {
                    Console.WriteLine("UnexpectedException:{0}", e.ToString());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
            Console.ReadKey();
        }
    }
           
    class Program
        {
            static void Main(string[] args)
            {
            Cilent_Sychronous_Socket.StartClient();
            }

        }
    }

