using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SnakesNLadders___Client
{
    public partial class Game : Form
    {
        Point ImageSize = new Point(890, 670);

        Timer test = new Timer();
        Timer test1 = new Timer();
        Timer Tdice = new Timer();
        Label Player1 = new Label();
        Label Player2 = new Label();

        List<Point> Coordinates = new List<Point>(100);
        int Counter1 = 0;
        int Counter2 = 0;

        public Game()
        {
            InitializeComponent();
            pictureBox6.Enabled = false;
            P1PIC.SizeMode = PictureBoxSizeMode.StretchImage;

            test.Interval = 100;  // Timer interval is 1/10 second
            test.Enabled = true;
            test.Tick += new System.EventHandler(timertest); // Timer interval is 1/10 second


            test1.Interval = 500;  // Timer interval is 1/10 second
            test1.Enabled = true;
            test1.Tick += new System.EventHandler(timertest2);

            Coordinates.Add(new Point(0, 0));
            bool LeftToRight = true;
            for (int Vertical = ImageSize.Y; Vertical >= 0; Vertical -= ImageSize.Y / 10)
            {
                if (LeftToRight)
                {

                    for (int Horizontal = ImageSize.X / 10; Horizontal <= ImageSize.X; Horizontal += ImageSize.X / 10)
                    {
                        Coordinates.Add(new Point(Horizontal, Vertical));
                    }
                    LeftToRight = false;

                }
                else
                {

                    for (int Horizontal = ImageSize.X; Horizontal >= ImageSize.X / 10; Horizontal -= ImageSize.X / 10)
                    {
                        Coordinates.Add(new Point(Horizontal, Vertical));
                    }
                    LeftToRight = true; ;
                }
            }
        }

        private void timertest(object sender, EventArgs e)
        {
            Player1.Text = Counter1.ToString();
            Player1.BringToFront();
            Player1.Location = Coordinates[Counter1];
            Player1.Location = new Point(Player1.Location.X, Player1.Location.Y + 5);
            Controls.Add(Player1);
            Counter1++;
            if (Counter1 == 101)
                Counter1 = 1;
        }

        private void timertest2(object sender, EventArgs e)
        {
            //pictureBox6.Text = Counter2.ToString();
            P1PIC.Location = Coordinates[Counter2];
            Controls.Add(P1PIC);
            P1POS.Text = "" + Counter2;
            Counter2++;
            P1PIC.BringToFront();

            if (Counter2 == 101)
                Counter2 = 1;
        }
        private int DiceRoll()
        {
            int result;
            Random rnd = new Random();

            result = rnd.Next(1, 7);
            return result;
        }
        private void btnshake_Click(object sender, EventArgs e)
        {
            dicenumber.Text = "" + DiceRoll();
        }
    }
}

