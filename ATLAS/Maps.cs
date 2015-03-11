using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLAS
{
    class Maps
    {        
        List <string> maps; // collection for list of maps
        public float x0, y0; // new coordinates(X, Y) for draw map 
        public float DownX, DownY; // fixed X and Y coordinates when mouse down on picture
        float scale; // map's scale
        Bitmap bmp;
        Image image;
        double[] ScMass; // array that store data of scales for trackbar        

        public Maps()
        {
            maps = new List<string>();
            scale = 1;
            x0 = y0 = 0;
            DownX = DownY = -1;
            ScMass = LoadMassScale();            
        }        

        // Set default settings for DrawMap
        public int DefaultMapSetting()
        {
            x0 = y0 = 0;
            scale = 1;
            return 10; // value for trackbar
        }

        // Load list of maps
        public List<string> LoadMaps(string map)
        {
            maps.Clear();
            try
            {
                DirectoryInfo di = new DirectoryInfo("Maps\\" + map + "\\");
                FileInfo[] info = di.GetFiles("*.tif", SearchOption.TopDirectoryOnly);
                foreach (FileInfo file in info)
                {
                    string fullname = file.FullName;
                    string name = file.Name.Replace(".tif", "");
                    maps.Add(name);
                }
                return maps;
            }
            catch
            {
                MessageBox.Show("Дані тимчасово відсутні!", "Атлас вибачається",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }           
        }

        // Load map in first time, when selected index change in comboBox_map_content
        public void DrawMap(string map, string path, Image image) 
        {
            this.image = image;
            try
            {
                bmp = new Bitmap("Maps\\" + path + "\\" + map + ".tif");
                using (Graphics gr = Graphics.FromImage(image))
                {
                    gr.DrawImage(Image.FromFile("wooden-table-background.jpg"), 0, 0,
                        image.Width, image.Height); // background for map("Table for map")
                    gr.DrawImage(bmp, x0, y0, bmp.Width * scale, bmp.Height * scale);
                }
            }
            catch
            {
                MessageBox.Show("Помилка при візуалізації даних!", "Атлас вибачається",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }   
        }       

        // Override method for Maps.cs
        public void DrawMap() 
        {            
            try
            {
                using (Graphics gr = Graphics.FromImage(image))
                {
                    gr.DrawImage(Image.FromFile("wooden-table-background.jpg"), 0, 0, image.Width, image.Height);
                    gr.DrawImage(bmp, x0, y0, bmp.Width * scale, bmp.Height * scale);
                }                
            }
            catch
            {
                MessageBox.Show("Дані тимчасово відсутні!", "Атлас вибачається",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                    
        }

        public void DownMouse(object sender, MouseEventArgs e)
        {            
            if (bmp != null)
            {
                float x = e.X + bmp.Width * scale;
                float y = e.Y + bmp.Height * scale;
                if (x0 <= x && y0 <= y)
                {
                    DownX = e.X;
                    DownY = e.Y;
                }
            }
        }        

        public void MoveMap(object sender, MouseEventArgs e, bool handID)
        {            
            if (handID)
            {
                if (DownX >= 0 && DownY >= 0)
                {
                    x0 += e.X - DownX;
                    y0 += e.Y - DownY;
                    DownX = e.X;
                    DownY = e.Y;
                    DrawMap();
                }                
            }
        }

        public void UpMouse()
        {
            DownX = -1;
            DownY = -1;
        }

        // Move map by buttons
        public void ButtonMoveMap(Directions direction)
        {
            switch(direction)
            {
                case Directions.Up: x0 += 0;
                             y0 += 100;
                             DrawMap();
                             break;
                case Directions.Down: x0 += 0;
                             y0 += -100;
                             DrawMap();
                             break;
                case Directions.Right: x0 += -100;
                             y0 += 0;
                             DrawMap();
                             break;
                case Directions.Left: x0 += 100;
                             y0 += 0;
                             DrawMap();
                             break;
            }
        }

        // Change map's scale by mouse
        public int MapScaling(object sender, MouseEventArgs e, int trVal)
        {
            if (bmp != null)
            {
                float x = x0 + bmp.Width * scale;
                float y = y0 + bmp.Height * scale;
                if (e.X <= x && e.Y <= y)
                {
                    x = (e.X - x0) / scale;
                    y = (e.Y - y0) / scale;
                    float ds = 0;
                    if (e.Delta > 0)
                    {
                        if(trVal!=19)
                        {
                            ds = scale * 1.25f;
                            trVal++;
                        }                        
                    }
                    else
                    {
                        if(trVal!=0)
                        {
                            ds = scale / 1.25f;
                            trVal--;
                        }                        
                    }
                    if (ds >= 0.1) scale = ds;
                    x0 = e.X - x * scale;
                    y0 = e.Y - y * scale;
                    DrawMap();
                }
            }
            return trVal;
        }

        // Change map's scale by trackbar
        public void TrackScale(int index)
        {            
            scale = (float)ScMass[index];
            DrawMap();
        }

        // Count data of scales for change scale by trackbar
        private double [] LoadMassScale()
        {
            double[] ScMass = new double[20];
            ScMass[9] = 1;
            for (int i = 10; i < ScMass.Length; i++)
            {
                ScMass[i] = (ScMass[i - 1] * 1.25);
            }
            for (int i = 8; i >= 0; i--)
            {
                ScMass[i] = (ScMass[i + 1] / 1.25);
            }
            return ScMass;
        }

        // Make screenshot from map
        public void MakeMapScreenShot(SaveFileDialog sfd)
        {
            if (!Directory.Exists("ScreenShots"))
            {
                Directory.CreateDirectory("ScreenShots");
            }
            string initPath = Path.GetFullPath("ScreenShots");
            sfd.InitialDirectory = Path.GetFullPath(initPath);
            sfd.FileName = "";                             
            if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (bmp != null)
                        {
                            Bitmap temp = (Bitmap)image;
                            //bmp.Clone(new Rectangle(Math.Abs((int)x0), Math.Abs((int)y0), 1086, 698),
                            //    PixelFormat.Format32bppPArgb);                                                                                
                            temp.Save(sfd.FileName);
                            MessageBox.Show("Зображення успішно збережено в папці Screenshots!", "Screenshots",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }  
                    }
                    catch
                    {
                        MessageBox.Show("Помилка при збереженні зображення!", "Screenshots",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            else 
                return;                                 
        }        
    }
}
