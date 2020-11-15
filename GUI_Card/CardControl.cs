using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Card
{

    class CardControl : Control
    {
        Bitmap img;
        Pen pen;
        SolidBrush drawBrush;
        string CardValue;
        public CardControl(string value, int field)
        {
            switch (field)
            {
                case 1: img = new Bitmap(GUI_Card.Properties.Resources.clubs); drawBrush = new SolidBrush(Color.Black); break;
                case 2: img = new Bitmap(GUI_Card.Properties.Resources.diamonds); drawBrush = new SolidBrush(Color.Red); break;
                case 3: img = new Bitmap(GUI_Card.Properties.Resources.hearts); drawBrush = new SolidBrush(Color.Red); break;
                case 4: img = new Bitmap(GUI_Card.Properties.Resources.spades); drawBrush = new SolidBrush(Color.Black); break;
            }
            this.CardValue = value;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Call the OnPaint method of the base class.
            base.OnPaint(e);

            //draw rectangle
            int x = 0;
            int y = 0;
            int radius = 20;
            int width = this.Width;
            int height = this.Height;

            Rectangle corner = new Rectangle(x, y, radius, radius);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(corner, 180, 90);
            corner.X = x + width - radius;
            path.AddArc(corner, 270, 90);
            corner.Y = y + height - radius;
            path.AddArc(corner, 0, 90);
            corner.X = x;
            path.AddArc(corner, 90, 90);
            path.CloseFigure();

            e.Graphics.FillPath(Brushes.White, path);

            //draw bitmap

            int imgWidth = img.Width;
            int imgHeight = img.Height;

            int imgScale = imgHeight/imgWidth;
            if (imgScale == 0) imgScale = 1;

            imgHeight = (int)(this.Height * 0.2);
            imgWidth = (int)(imgHeight / (imgScale*1.0));

            Bitmap bmp = new Bitmap(img,imgWidth,imgHeight);
            
            x = (this.Height - imgHeight) / 2;
            y = (this.Width - imgWidth) / 2;
            e.Graphics.DrawImage(bmp,y,x);

            //draw label;

            float FontSize =(int)(this.Height * 0.08);

            // Set up string.
            string measureString = CardValue;
            Font stringFont = new Font("Arial", FontSize);

            // Measure string.
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(measureString, stringFont);


            e.Graphics.DrawString(CardValue, new Font("Arial", FontSize), drawBrush, new Point(1, 1));
            e.Graphics.DrawString(CardValue, new Font("Arial", FontSize), drawBrush, new Point(this.Width - (int)stringSize.Width, this.Height - (int)stringSize.Height));

            // Draw string to screen.




        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

        }
    }
}
