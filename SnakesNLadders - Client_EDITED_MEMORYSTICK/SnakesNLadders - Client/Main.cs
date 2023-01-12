using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesNLadders___Client
{
    public partial class Main : Form
    {
        private Form server;
        private Form connection;
        private Form test;
        public Main()
        {
            InitializeComponent();
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            if (connection == null || (connection != null && connection.IsDisposed))
            {
                connection = new LOBBY();
            }
            if (!connection.Visible)
            {
                connection.Show();
            }
            else
            {
                connection.BringToFront();
            }
        }

        private void btn_host_Click(object sender, EventArgs e)
        {
            if (server == null || (server != null && server.IsDisposed))
            {
                server = new Host();
            }
            if (!server.Visible)
            {
                server.Show();
            }
            else
            {
                server.BringToFront();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (test == null || (test != null && test.IsDisposed))
            {
                test = new Game();
            }
            if (!test.Visible)
            {
                test.Show();
            }
            else
            {
                test.BringToFront();
            }
        }
    }
}
