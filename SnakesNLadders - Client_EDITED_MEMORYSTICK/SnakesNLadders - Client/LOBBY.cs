using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

using System.Windows.Forms;


namespace SnakesNLadders___Client
{
    public partial class LOBBY : Form
    {
        Socket m_ClientSocket;
        System.Net.IPEndPoint m_remoteEndPoint;
        private static System.Windows.Forms.Timer m_CommunicationActivity_Timer;
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public LOBBY()
        {
            InitializeComponent();
            m_CommunicationActivity_Timer = new System.Windows.Forms.Timer(); // Check for communication activity on Non-Blocking sockets every 200ms
            m_CommunicationActivity_Timer.Interval = 100;  // Timer interval is 1/10 second
            m_CommunicationActivity_Timer.Enabled = false;
            string szLocalIPAddress = GetLocalIPAddress_AsString();
            textBox4.Text = szLocalIPAddress;             // Place local IP address in IP address field
            textBox5.Text = "8000";
        }
        byte[] receivedBuf = new byte[1024];
        //Thread thr;
        private void button1_Click_1(object sender, EventArgs e)
        {
            

            //dissconect


        }




        public string GetLocalIPAddress_AsString()
        {
            string szHost = Dns.GetHostName();
            string szLocalIPaddress = "127.0.0.1";  // Default is local loopback address
            IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in IPHost.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork) // Match only the IPv4 address
                {
                    szLocalIPaddress = IP.ToString();
                    break;
                }
            }
            return szLocalIPaddress;
        }

        private void Close_Socket_and_Exit()
        {
            try
            {
                m_ClientSocket.Shutdown(SocketShutdown.Both);
            }
            catch // Silently handle any exceptions
            {
            }
            try
            {
                m_ClientSocket.Close();
            }
            catch // Silently handle any exceptions
            {
            }
            this.Close();
        }

        private void ReceiveData(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            int received = socket.EndReceive(ar);
            byte[] dataBuf = new byte[received];
            Array.Copy(receivedBuf, dataBuf, received);
            m_ClientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), m_ClientSocket);
            richTextBox1.AppendText(Encoding.ASCII.GetString(dataBuf));
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                label3.Text = "Please Enter a Username";
            }else
            {
            
            label3.Text = "Connecting";
            myTimer.Interval = 5000;

            {   // Connect the Socket with a remote endpoint
                try
                {
                    // Create the socket, for TCP use
                    m_ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    m_ClientSocket.Blocking = true; // Socket operates in Blocking mode initially
                    label3.Text = "Succesfully Connected";
                        button5.Enabled = false;
                        button1.Enabled = true;
                        button3.Enabled = true;
                        button2.Enabled = true;
                }
                catch // Handle any exceptions
                {
;                    label3.Text = "Failed";
                        button1.Enabled = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button5.Enabled = true;
                        Close_Socket_and_Exit();
                }
                try
                {
                    // Get the IP address from the appropriate text box
                    String szIPAddress = textBox4.Text;
                    System.Net.IPAddress DestinationIPAddress = System.Net.IPAddress.Parse(szIPAddress);

                    //Start timer
                    myTimer.Start();

                    // Get the Port number from the appropriate text box
                    String szPort = textBox5.Text;
                    int iPort = System.Convert.ToInt16(szPort, 10);

                    // Combine Address and Port to create an Endpoint
                    m_remoteEndPoint = new System.Net.IPEndPoint(DestinationIPAddress, iPort);


                    m_ClientSocket.Connect(m_remoteEndPoint);
                    m_ClientSocket.Blocking = false;    // Socket is now switched to Non-Blocking mode for send/ receive activities
                    button1.Enabled = false;
                    m_CommunicationActivity_Timer.Start();  // Start the timer to perform periodic checking for received 
                    m_ClientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), m_ClientSocket);
                    byte[] buffer = Encoding.ASCII.GetBytes("/User:" + textBox6.Text);
                    m_ClientSocket.Send(buffer);
                    label3.Text = "Succesfully Connected";
                }
                catch // Catch all exceptions
                {   // If an exception occurs, display an error message
                    label3.Visible = true;
                    label3.Text = "Connecting Failed";
                        button1.Enabled = false;
                        button3.Enabled = false;
                        button2.Enabled = false;
                        button5.Enabled = true;
                    }
            }
        }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
                textBox3.Text = "";
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
                try
            {
                String szData = "/Mesg:" + textBox3.Text;
                if (szData.Equals(""))
                {
                    szData = "Default message";
                }
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(szData);
                m_ClientSocket.Send(byData, SocketFlags.None);
                //richTextBox1.AppendText("\nUser: " + textBox3.Text);
            }
            catch // Silently handle any exceptions
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game GameScreen = new Game();
            GameScreen.Visible = true;
            GameScreen.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        
    }
    }

