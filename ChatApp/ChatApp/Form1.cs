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

namespace ChatApp
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal;
        EndPoint epDestination;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get user Ip
            tbLocalIP.Text = GetLocalIP();
            tbDestinationIP.Text = GetLocalIP();



        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip  in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            //binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(tbLocalIP.Text), Convert.ToInt32(tbLocalPort.Text));
            sck.Bind(epLocal);

            //Connecting to remote Ip
            epDestination = new IPEndPoint(IPAddress.Parse(tbDestinationIP.Text), Convert.ToInt32(tbDestinationPort.Text));
            sck.Connect(epDestination);

            //Listening for a specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epDestination, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {

            try
            {
                byte[] recieveData = new byte[1500];
                recieveData = (byte[])aResult.AsyncState;

                //Converting byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string recievedMessage = aEncoding.GetString(recieveData);

                //Adding the message into ListBox
                lbMessage.Items.Add("Friend:   " + recievedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epDestination, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
           
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Convert string message to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(tbMessage.Text);

            //Sending the encoded message
            sck.Send(sendingMessage);

            //adding to the listbox
            lbMessage.Items.Add("Me:  " + tbMessage.Text);
            tbMessage.Text = "";
        }
    }
}
