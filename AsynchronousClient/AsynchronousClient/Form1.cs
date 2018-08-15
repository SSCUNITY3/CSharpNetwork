using System;
using System.Windows.Forms;
using LahoreSocketAsync;


namespace AsynchronousClient
{

    public partial class Form1 : Form
    {
        LahoreSocketClient client = new LahoreSocketClient();
        string ip;
        string serverPortNumber;
        string strInputUser = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ip != null && serverPortNumber != null)
            {
                if (!client.SetServerIPAddress(ip) || !client.SetPortNumber(serverPortNumber))
                {
                    MessageBox.Show(string.Format("Wrong IP Address or port number supplied - {0} - {1} - Press a key to exit",ip,serverPortNumber),"Incorrect IP Address or PortNumber",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    return;
                }

                client.ConnectToServer();

            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            client.SendToServer(strInputUser);
            DisplayText.Text = "";
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
                    serverPortNumber = portNumberTextBox.Text;

                }
                catch (Exception excp)
                {
                    Console.WriteLine(excp.ToString());

                }
            }
        }

        private void DisplayText_TextChanged(object sender, EventArgs e)
        {
                strInputUser = DisplayText.Text;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            client.CloseAndDisconnect();
            Application.Exit();
        }

        private void serverMessage_TextChanged(object sender, EventArgs e)
        {
            if (LahoreSocketClient.inputMessage != null)
            {
                serverMessage.Text = LahoreSocketClient.inputMessage;
                serverMessage.Update();
                LahoreSocketClient.setNull();
            }
            else
                serverMessage.Text = "serverMessage here!!";
        }
    }
}
