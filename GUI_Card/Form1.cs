using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Card
{
    public partial class Form1 : Form
    {
        string CardValue = "1";
        int Field = 1;
        bool isPlay = true;
        Timer myTimer = new Timer();
        bool isStart = false;
        public Form1()
        {
            InitializeComponent();
            myTimer.Tick += MyTimer_Tick;
            myTimer.Interval = 1000;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            int value = new Random().Next(1, 13);
            int field = new Random().Next(1, 4);

            Field = field;

            switch (value)
            {
                case 1:
                    CardValue = "A";
                    break;
                case 11:
                    CardValue = "J";
                    break;
                case 12:
                    CardValue = "Q";
                    break;
                case 13:
                    CardValue = "K";
                    break;
                default:
                    CardValue = value.ToString();
                    break;
            }

            // CardControl card = new CardControl(CardValue,Field);
            //card.Dock = DockStyle.Fill;
            //panel_Card.Controls.Clear();
            //panel_Card.Controls.Add(card);
            ResizeAllControl();
        }

        public void ResizeAllControl()
        {
            //size lá bài là 3.5, 2.5 ---> scale = 1.4
            //set height, and width of panel;

            int panel_height = (int)(this.Height * 0.6);
            int panel_width = (int)(panel_height / 1.4);

            //set vị trí cho panel
            int point_x = (int)(this.Height * 0.1);
            int point_y = (int)((this.Width - panel_width) / 2);
            Point point_start = new Point(point_y, point_x);

            panel_Card.Location = point_start;
            panel_Card.Size = new Size(panel_width, panel_height);

            CardControl card = new CardControl(CardValue, Field);
            card.Dock = DockStyle.Fill;
            panel_Card.Controls.Clear();
            panel_Card.Controls.Add(card);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            isStart = true;

            if (isPlay)
            {
                myTimer.Stop(); isPlay = false;
                button1.Text = "Bắt đầu";
            }
            else
            {
                myTimer.Start();
                isPlay = true;
                button1.Text = "Kết thúc";
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (isStart) ResizeAllControl();
        }



    }
}
