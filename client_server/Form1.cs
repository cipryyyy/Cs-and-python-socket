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

namespace client_server
{
    public class Client
    {
        public static IPEndPoint server;
        public static Socket sender;
        public static void StartClient()
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPHostEntry host = Dns.GetHostEntry("192.168.1.109");
                IPAddress ip = host.AddressList[0];
                server = new IPEndPoint(ip, 8000);

                sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(server);
                Console.WriteLine("Connected to {0}", server);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot connect to server\n{0}", e.ToString());
            }
        }

        public static void SendClient(string msg)
        {
            byte[] message = Encoding.ASCII.GetBytes(msg);
            int byteSent = sender.Send(message);
            Console.WriteLine("Sending {0}", msg);
        }

    }
    public partial class Form1 : Form
    {
        bool isFullscreen = false;

        public Form1()
        {
            InitializeComponent();
            Client.StartClient();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            label.Text = "Benvenuto!";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Client.SendClient("END");
            Application.Exit();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            label.Text = "Caricamento di un file in corso...";
            Client.SendClient("CARICA");
        }

        private void download_Click(object sender, EventArgs e)
        {
            label.Text = "Scarico un file...";
            Client.SendClient("SCARICA");
        }

        private void settings_Click(object sender, EventArgs e)
        {
            label.Text = "Apertura impostazioni...";
        }

        private void fullscreen_Click(object sender, EventArgs e)
        {
            if (isFullscreen == false)
            {
                isFullscreen = true;
                fullscreen.BackgroundImage = Properties.Resources.fullscreeen;
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                isFullscreen = false;
                fullscreen.BackgroundImage = Properties.Resources.maximize;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.exit_hover;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.exit;
        }
    }
}
