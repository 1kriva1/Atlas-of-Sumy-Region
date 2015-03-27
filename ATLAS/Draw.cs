using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLAS
{
    class Draw
    {
        Bitmap temp;        
        public RichTextBox txt; // Text insert on map
        PictureBox pictureBox_map;
        FontDialog fontDialog;
        NumericUpDown numeric;
        Graphics g;        

        public Draw(PictureBox pictureBox_map, FontDialog fontDialog, NumericUpDown numeric)
        {
            this.numeric = numeric;            
            this.fontDialog = fontDialog;
            this.pictureBox_map = pictureBox_map;            
        }

        // Draw rectangle
        public void DrawRectangle(Bitmap bmp, Pen pen, int x1, int y1, int x2, int y2)
        {
            temp = (Bitmap)bmp.Clone();
            pictureBox_map.Image = temp;
            using(Graphics g = Graphics.FromImage(temp))
            {
                if (x1 > x2 && y1 > y2)
                    g.DrawRectangle(pen, x2, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else if (x2 > x1 && y1 > y2)
                    g.DrawRectangle(pen, x1, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else if (x2 < x1 && y2 > y1)
                    g.DrawRectangle(pen, x2, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else
                    g.DrawRectangle(pen, x1, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            }
            pen.Dispose();
        }

        // Draw fill rectangle
        public void DrawRectangleFill(Bitmap bmp, SolidBrush brush, int x1, int y1, int x2, int y2)
        {
            temp = (Bitmap)bmp.Clone();
            pictureBox_map.Image = temp;            
            using (Graphics g = Graphics.FromImage(temp))
            {
                if (x1 > x2 && y1 > y2)
                    g.FillRectangle(brush, x2, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else if (x2 > x1 && y1 > y2)
                    g.FillRectangle(brush, x1, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else if (x2 < x1 && y2 > y1)
                    g.FillRectangle(brush, x2, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else
                    g.FillRectangle(brush, x1, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            }
            brush.Dispose();
        }

        //Draw line
        public void DrawLine(Bitmap bmp, Pen pen, int x1, int y1, int x2, int y2)
        {
            temp = (Bitmap)bmp.Clone();
            pictureBox_map.Image = temp;            
            using (Graphics g = Graphics.FromImage(temp))
            {
                g.DrawLine(pen, x1, y1, x2, y2);
            }
            pen.Dispose();            
        }

        //Draw ellipse
        public void DrawElipse(Bitmap bmp, Pen pen, int x1, int y1, int x2, int y2)
        {
            temp = (Bitmap)bmp.Clone();
            pictureBox_map.Image = temp;            
            using (g = Graphics.FromImage(temp))
            {
                if (x1 > x2 && y1 > y2)
                    g.DrawEllipse(pen, x2, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else if (x2 > x1 && y1 > y2)
                    g.DrawEllipse(pen, x1, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else if (x2 < x1 && y2 > y1)
                    g.DrawEllipse(pen, x2, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else
                    g.DrawEllipse(pen, x1, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            }
            pen.Dispose();           
        }

        //Draw fill ellipse
         public void DrawElipseFill(Bitmap bmp, SolidBrush brush, int x1, int y1, int x2, int y2)
        {
            temp = (Bitmap)bmp.Clone();            
            pictureBox_map.Image = temp;            
            using (g = Graphics.FromImage(temp))
            {
                if (x1 > x2 && y1 > y2)
                    g.FillEllipse(brush, x2, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else if (x2 > x1 && y1 > y2)
                    g.FillEllipse(brush, x1, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else if (x2 < x1 && y2 > y1)
                    g.FillEllipse(brush, x2, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                else
                    g.FillEllipse(brush, x1, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            }
            brush.Dispose();                      
        }
        
        // Draw like pen
        public void DrawPen(Bitmap bmp, Pen pen, ref int x1, ref int y1, int x2, int y2)
        {
            pictureBox_map.Image = bmp;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLine(pen, x1, y1, x2, y2);
            } 
            pen.Dispose();           
            x1 = x2;
            y1 = y2;            
        }

        //Eraser
        public void DrawClean(Bitmap bmp, Pen pen, ref int x1, ref int y1, int x2, int y2)
        {
            numeric.Value = 5;
            pictureBox_map.Image = bmp;
            pen.Color = Color.White;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLine(pen, x1, y1, x2, y2);
            }
            pen.Dispose();           
            x1 = x2;
            y1 = y2;
        }

        // Insert text
        public void DrawText(int x1, int y1)
        {
            txt = new RichTextBox();
            txt.Location = new Point(x1, y1);
            txt.Width = 120;
            txt.Height = 45;
            txt.Multiline = true;
            txt.Leave += new EventHandler(txt_Leave);
            pictureBox_map.Controls.Add(txt);
            txt.Focus();
        }

        // Event when RichTextBox leave
        public void txt_Leave(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox_map.Image);
            g.DrawString(((RichTextBox)sender).Text, fontDialog.Font, Brushes.Black, ((RichTextBox)sender).Location);
            ((RichTextBox)sender).Leave -= new EventHandler(txt_Leave);
            pictureBox_map.Controls.Remove((RichTextBox)sender);
            ((RichTextBox)sender).Dispose();            
            pictureBox_map.Refresh();
            txt = null;            
        }
    }
}
