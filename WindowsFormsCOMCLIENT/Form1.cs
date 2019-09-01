using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsCOMCLIENT
{
    public partial class Form1 : Form
    {
        public static string nick = "";
        public Form1()
        {
            InitializeComponent();
        }

        static IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        static IPAddress ipAddress = ipHostInfo.AddressList[0];
        static IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

        static Socket sender = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);

        private void Form1_Load(object Mainsender, EventArgs MainE)
        {

        }

        static string data = null;
        static byte[] bytes = new Byte[1024];
        public void GetMessageFromServer(Socket socket, object sander, EventArgs e)
        {
            try
            {
                while (true)
                {
                    if (SocketConnected(socket))
                    {
                        data = null;
                        bytes = new byte[1024];
                        int bytesRec = socket.Receive(bytes);
                        data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        BeginInvoke(new Action(() => history.Items.Add(data.ToString())));
                    }
                    else
                    {
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                    }
                    Thread.Sleep(10);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка соединения.");
            }
        }
        public static bool SocketConnected(Socket s)
        {
            try
            {
                bool part1 = s.Poll(1000, SelectMode.SelectRead);
                bool part2 = (s.Available == 0);
                if (part1 && part2)
                    return false;
                else
                    return true;
            }
            catch
            {
                MessageBox.Show("Вы не подключены!");
                return false;
            }
        }

        string message = "";
        private void SendMessage(object sender, EventArgs e, Socket socket)
        {
            if (nick.Trim() != "")
            {
                if (nick.Length >= 3)
                {
                    if (SocketConnected(socket))
                    {
                        if (message.TrimStart().TrimEnd() != null)
                        {
                            byte[] msg = Encoding.UTF8.GetBytes(message);
                            socket.Send(msg);
                            BeginInvoke(new Action(() => RichText.Text = ""));
                            BeginInvoke(new Action(() => message = ""));
                        }
                    }
                }
                else
                    MessageBox.Show("Ник не может короче 3 символов!");
            }
            else
                MessageBox.Show("Ник не может быть пустым!");
        }

        private void Say_Click(object Mainsender, EventArgs MainE)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                BeginInvoke(new Action(() => message = nick + ": " + RichText.Text));
                SendMessage(Mainsender, MainE, sender);
            }).Start();
        }

        private void Button1_Click(object Mainsender, EventArgs MainE)
        {
            try
            {
                ipAddress = IPAddress.Parse(CurretIp.Text);
                sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                remoteEP = new IPEndPoint(ipAddress, 11000);
                sender.Connect(remoteEP);
                history.Items.Add("Connected.");

                SetName sn = new SetName();
                sn.Show();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    GetMessageFromServer(sender, Mainsender, MainE);
                }).Start();
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show("ArgumentNullException: " + ane.ToString());
            }
            catch (SocketException se)
            {
                MessageBox.Show("SocketException: " + se.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Unexpected exception: " + e.ToString());
            }
        }


        private void Button2_Click(object Mainsender, EventArgs MainE)
        {
            if (sender != default)
                if (SocketConnected(sender))
                    sender.Close();
        }
    }
}
