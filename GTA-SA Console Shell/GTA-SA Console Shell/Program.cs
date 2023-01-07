using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace GTA_SA_Shell
{
    class Program
    {
        public static IPAddress ip = IPAddress.Parse("192.168.0.103");
        //public static IPAddress ip = IPAddress.Parse("127.0.0.1");

        public static int port = 54000;
        public static int portstart = 16521;

        public static void GETW()
        {
            Console.Clear();
            string address = "";
            while (true)
            {
                Console.Write("INPUT ADDRESS (WORD DATA 2b) (` - back): ");
                try { address = Console.ReadLine().Trim(); if (address == "`") { Console.Clear(); return; } if ((address.Contains("0x")) && (address.Length == 8) || (address.Length == 6)) { break; } } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"getw {address}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            Console.ReadKey();
            Console.Clear();
        }
        public static void SETW()
        {
            Console.Clear();
            //int value = 0;
            string value = "";
            string address = "";
            while (true)
            {
                Console.Write("INPUT ADDRESS (` - back): ");
                try { address = Console.ReadLine().Trim(); if (address == "`") { Console.Clear(); return; } if ((address.Contains("0x")) && (address.Length == 8) || (address.Length == 6)) { break; } } catch { }
                Console.Clear();
            }
            while (true)
            {
                Console.Write("INPUT VALUE (WORD DATA 2b): ");
                try { /*value = int.Parse(Console.ReadLine());*/ value = Console.ReadLine(); break; } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"setw {address} {value}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

        public static void GETD()
        {
            Console.Clear();
            string address = "";
            while (true)
            {
                Console.Write("INPUT ADDRESS (DWORD DATA 4b) (` - back): ");
                try { address = Console.ReadLine().Trim(); if (address == "`") { Console.Clear(); return; } if ((address.Contains("0x")) && (address.Length == 8) || (address.Length == 6)) { break; } } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"getd {address}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            Console.ReadKey();
            Console.Clear();
        }
        public static void SETD()
        {
            Console.Clear();
            //int value = 0;
            string value = "";
            string address = "";
            while (true)
            {
                Console.Write("INPUT ADDRESS (` - back): ");
                try { address = Console.ReadLine().Trim(); if (address == "`") { Console.Clear(); return; } if ((address.Contains("0x")) && (address.Length == 8) || (address.Length == 6)) { break; } } catch { }
                Console.Clear();
            }
            while (true)
            {
                Console.Write("INPUT VALUE (DWORD DATA 4b): ");
                try { /*value = int.Parse(Console.ReadLine());*/ value = Console.ReadLine(); break; } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"setd {address} {value}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

        public static void GETB()
        {
            Console.Clear();
            string address = "";
            while (true)
            {
                Console.Write("INPUT ADDRESS (BYTE DATA 1b) (` - back): ");
                try { address = Console.ReadLine().Trim(); if (address == "`") { Console.Clear(); return; } if ((address.Contains("0x")) && (address.Length == 8) || (address.Length == 6)) { break; } } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"getb {address}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            Console.ReadKey();
            Console.Clear();
        }
        public static void SETB()
        {
            Console.Clear();
            //int value = 0;
            string value = "";
            string address = "";
            while (true)
            {
                Console.Write("INPUT ADDRESS (` - back): ");
                try { address = Console.ReadLine().Trim(); if (address == "`") { Console.Clear(); return; } if ((address.Contains("0x")) && (address.Length == 8) || (address.Length == 6)) { break; } } catch { }
                Console.Clear();
            }
            while (true)
            {
                Console.Write("INPUT VALUE (BYTE DATA 1b): ");
                try { /*value = int.Parse(Console.ReadLine());*/ value = Console.ReadLine(); break; } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"setb {address} {value}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

        public static void GETF()
        {
            Console.Clear();
            string address = "";
            while (true)
            {
                Console.Write("INPUT ADDRESS (FLOAT DATA) (` - back): ");
                try { address = Console.ReadLine().Trim(); if (address == "`") { Console.Clear(); return; } if ((address.Contains("0x")) && (address.Length == 8) || (address.Length == 6)) { break; } } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"getf {address}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            Console.ReadKey();
            Console.Clear();
        }
        public static void SETF()
        {
            Console.Clear();
            //int value = 0;
            string value = "";
            string address = "";
            while (true)
            {
                Console.Write("INPUT ADDRESS (` - back): ");
                try { address = Console.ReadLine().Trim(); if (address == "`") { Console.Clear(); return; } if ((address.Contains("0x")) && (address.Length == 8) || (address.Length == 6)) { break; } } catch { }
                Console.Clear();
            }
            while (true)
            {
                Console.Write("INPUT VALUE: ");
                try { /*value = int.Parse(Console.ReadLine());*/ value = Console.ReadLine(); break; } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"setf {address} {value}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

        public static void KEYC()
        {
            Console.Clear();
            //int value = 0;
            string value = "";
            while (true)
            {
                Console.Write("INPUT VALUE (AEZAKMI..) (` - back): ");
                try { /*value = int.Parse(Console.ReadLine());*/ value = Console.ReadLine(); if (value == "`") { Console.Clear(); return; } break; } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"keyc {value.ToUpper()}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        public static void KEYH()
        {
            Console.Clear();
            //int value = 0;
            string value = "";
            while (true)
            {
                Console.Write("KEYS INT INPUT VALUE (114 115..) (` - back): ");
                try { /*value = int.Parse(Console.ReadLine());*/ value = Console.ReadLine(); if (value == "`") { Console.Clear(); return; } break; } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = $"keyh {value}";
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

        public static void START()
        {
            Console.Clear();
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, portstart);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = "START";
                byte[] bytesh = Encoding.Unicode.GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        public static void RESTART()
        {
            Console.Clear();
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, portstart);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = "RESTART";
                byte[] bytesh = Encoding.Unicode.GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        public static void STOP()
        {
            Console.Clear();
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, portstart);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = "STOP";
                byte[] bytesh = Encoding.Unicode.GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

        public static void WS9001()
        {
            Console.Clear();
            //int value = 0;
            string value = "";
            while (true)
            {
                Console.Write("INPUT WEBSOCKET MESSAGE (` - back): ");
                try { /*value = int.Parse(Console.ReadLine());*/ value = Console.ReadLine(); if (value == "`") { Console.Clear(); return; } break; } catch { }
                Console.Clear();
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, 9001);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = value;
                byte[] bytesh = Encoding.GetEncoding(1251).GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.GetEncoding(1251).GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            Console.ReadKey();
            Console.Clear();
        }
        public static void TEST()
        {
            Console.Clear();
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ip, port);

                byte[] data = new byte[20480];
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                string responseh = "TEST";
                byte[] bytesh = Encoding.Unicode.GetBytes(responseh);
                stream.Write(bytesh, 0, bytesh.Length);

                do
                {
                    int bytes = stream.Read(data, 0, bytesh.Length);
                    response.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                stream.Close();
                client.Close();
                Console.WriteLine(response.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                bool exit = false;
                Console.WriteLine("1. GET WORD (2b)");
                Console.WriteLine("2. SET WORD (2b)");
                Console.WriteLine();
                Console.WriteLine("3. GET DWORD (4b)");
                Console.WriteLine("4. SET DWORD (4b)");
                Console.WriteLine();
                Console.WriteLine("5. GET BYTE (1b)");
                Console.WriteLine("6. SET BYTE (1b)");
                Console.WriteLine();
                Console.WriteLine("7. GET FLOAT (xb)");
                Console.WriteLine("8. SET FLOAT (xb)");
                Console.WriteLine();
                Console.WriteLine("9. KEYS CHAR CODES ARRAY");
                Console.WriteLine("0. KEYS INT  CODES ARRAY");
                Console.WriteLine();
                Console.WriteLine("+. START    GTA:SA");
                Console.WriteLine("-. RESTART  GTA:SA");
                Console.WriteLine(".. STOP     GTA:SA");
                Console.WriteLine();
                Console.WriteLine("*. WS 9001");
                Console.WriteLine("/. TEST");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.Clear();
                        GETW();
                        break;

                    case '2':
                        Console.Clear();
                        SETW();
                        break;

                    case '3':
                        Console.Clear();
                        GETD();
                        break;

                    case '4':
                        Console.Clear();
                        SETD();
                        break;

                    case '5':
                        Console.Clear();
                        GETB();
                        break;

                    case '6':
                        Console.Clear();
                        SETB();
                        break;

                    case '7':
                        Console.Clear();
                        GETF();
                        break;

                    case '8':
                        Console.Clear();
                        SETF();
                        break;

                    case '9':
                        Console.Clear();
                        KEYC();
                        break;

                    case '0':
                        Console.Clear();
                        KEYH();
                        break;

                    case '+':
                        Console.Clear();
                        START();
                        break;

                    case '-':
                        Console.Clear();
                        RESTART();
                        break;

                    case '.':
                        Console.Clear();
                        STOP();
                        break;

                    case '*':
                        Console.Clear();
                        WS9001();
                        break;

                    case '/':
                        Console.Clear();
                        TEST();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
                if (exit) { break; }
            }
        }

        public class Config
        {
            public string ip = "";
            public int port = 0;
            public int portstart = 0;
            /*public static Config Deserialize(string json)
            {
                try { return JsonConvert.DeserializeObject<Config>(json); }
                catch { }
                return null;
            }
            public static string Serialize(Config _vkr)
            {
                try { return JsonConvert.SerializeObject(_vkr, Formatting.Indented); }
                catch { }
                return null;
            }*/
        }
    }
}
