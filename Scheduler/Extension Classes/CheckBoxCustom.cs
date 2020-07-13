using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public class CheckBoxCustom : CheckBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);

            int height = ClientSize.Height - 2;

            Rectangle rectangle = new Rectangle(new Point(0, this.Height / 2 - height / 2), new Size(height, height));

            SolidBrush foreColorBrush = new SolidBrush(ForeColor);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen outerBorder = new Pen(Color.Black);

            //Draw border of box
            e.Graphics.DrawRectangle(outerBorder, rectangle);
            //Fill rectangle with white background
            e.Graphics.FillRectangle(whiteBrush, rectangle.X + 1, rectangle.Y + 1, rectangle.Width - 2, rectangle.Height - 2);

            if (Checked)
            {
                int margin = height / 8;
                int startX = rectangle.X + margin;
                int startY = rectangle.Y + margin;
                int endX = rectangle.Width - (margin * 2);
                int endY = rectangle.Height - (margin * 2);

                //Fill box with another box to symbolize "checked"
                Rectangle innerRectangle = new Rectangle(startX, startY, endX, endY);
                e.Graphics.FillRectangle(foreColorBrush, innerRectangle);
            }

            //Draw the text
            Size txtSize = TextRenderer.MeasureText(Text, Font);
            e.Graphics.DrawString(Text, Font, foreColorBrush, new Point(height + 3, height / 2 - (txtSize.Height / 2)));
        }
    }
}