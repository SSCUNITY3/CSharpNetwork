using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LahoreSocketAsync;
using System.Net;
namespace UdemyAsyncSocketServer
{
    public partial class Form1 : Form
    {
        LahoreSocketServer mServer;
        IPAddress serverIp = null;
        int serverPortNumber = 0;
        public string ip;

        public Form1()
        {
            InitializeComponent();
            mServer = new LahoreSocketServer();
        }

        private void btnAcceptIncomingAsync_Click(object sender, EventArgs e)
        {
            if (ip != null && serverPortNumber != 0)
            {
                serverIp = IPAddress.Parse(ip);
                mServer.StartListeningForIncomingConnection(serverIp, serverPortNumber);
            }
            if(ip!=null)
            {
                serverIp = IPAddress.Parse(ip);
                mServer.StartListeningForIncomingConnection(serverIp);

            }
            else
                mServer.StartListeningForIncomingConnection();
        }

        private void btnSendAll_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(txtMessage.Text.Trim());
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            mServer.StopServer();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mServer.StopServer();
        }

        private void ipAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ipAddressTextBox.Text != null)
            {
                ip = ipAddressTextBox.Text;
            }
            
        }

        private void portNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (portNumberTextBox.Text != null)
            {
                try
                {
                    serverPortNumber = Convert.ToInt32(portNumberTextBox.Text);

                }
                catch (Exception excp)
                {
                    Console.WriteLine(excp.ToString());

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
