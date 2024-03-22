using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            IPAddress address = IPAddress.Parse(textBoxIP.Text);

            int port = int.Parse(textBoxPort.Text);

            IPEndPoint endPoint = new IPEndPoint(address, port);

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                socket.Connect(endPoint);
                if (socket.Connected)
                {
                    string query = "GET\r\n\r\n";
                    socket.Send(Encoding.Default.GetBytes(query));
                    byte[] buffer = new byte[1024];
                    int len;
                    do
                    {
                        len = socket.Receive(buffer);
                        textBox2.Text += Encoding.Default.GetString(buffer, 0, len);
                    } while (socket.Available > 0);
                }
                else
                {
                    MessageBox.Show("Error connection!");
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start("ServerProject.exe");
        }
    }
}
