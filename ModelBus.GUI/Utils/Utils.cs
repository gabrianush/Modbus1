using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBus.GUI
{
    public static class Utils
    {
        public static void DrawText(this Graphics graphics, string text, Font font, Point location, Size userControlSize)
        {
            LinearGradientBrush backGroundBrush = 
                new LinearGradientBrush(new Rectangle(0, 0, userControlSize.Width, userControlSize.Height),
                                        Color.DarkGray, 
                                        Color.WhiteSmoke, 
                                        LinearGradientMode.Horizontal);
            graphics.FillRectangle(backGroundBrush, new Rectangle(0, 0, userControlSize.Width, userControlSize.Height));

            Brush foreColorBrush = new SolidBrush(Color.Black);
            graphics.DrawString(text, font, foreColorBrush, location.X, location.Y);
        }

        public static void DrawTitle(this Graphics graphics, string title, Font font, Size userControlSize)
        {
            if (userControlSize.Width <= 0 || userControlSize.Height <= 0) return;
            var sizeFont = graphics.MeasureString(title, font);
            int delta = (userControlSize.Height - (int)sizeFont.Height) / 2;
            if(delta < 0)
            {
                throw new InvalidOperationException("Font prea mare tarane");
            }
            graphics.DrawText(title, font, new Point(delta, delta), userControlSize);
        }

        public static bool CloseForm(Form owner)
        {
            string title = string.Format("Close {0}?", owner.Text);
            string message = "Do you want to exit?";
            return MessageBox.Show(owner, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void ShowError(Form owner, string errMessage, bool close = false)
        {
             string title = string.Format("Error {0}", owner.Text);
             MessageBox.Show(owner, errMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if(close)
            {
                owner.Close();
            }
        }
    }
}
