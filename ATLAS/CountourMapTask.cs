using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLAS
{
    public enum DrawType
    {
        Rectangle,
        Line,
        Elipse,
        Pen,
        Clean,
        Text,
        RectangleFill,
        EllipseFill,        
        None
    }; // enumeration for type of draw

    public partial class CountourMapTask : Form
    {
        string territory = "", thema = ""; // territory and thema for task
        ControlController cc;
        CounterTaskList counterList;
        Draw draw;  
        string fullPath; 
        string connector; 
        List<string> task=new List<string>(); // store task for draw on counter map
        int DownX, CurrentX, DownY, CurrentY; // coordinates when mouse down and mouse move
        bool DrawFlag = false; // false - can't draw; true - draw
        Bitmap bmp;
        Image FirstMap; // image for "Refresh"              
        Pen pen;
        SolidBrush brush;
        DrawType drawType;      
        SQL sql;  
        Color color; // color for draw       
        Stack<Image> undo = new Stack<Image>();
        Stack<Image> redo = new Stack<Image>();

        public CountourMapTask()
        {
            InitializeComponent();
            cc = new ControlController();
            fullPath = Application.StartupPath.ToString() + @"\QuizzesData\CounterMap.mdf";
            connector = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+fullPath+";Integrated Security=True;";
            sql = new SQL(connector);
            draw = new Draw(pictureBox_map, fontDialog, numericUpDown_width);
            color = Color.Black; // default color
            drawType = DrawType.Pen; // default drawtype   
        }

        #region Settings

        // Refresh settings
        private void Init()
        {
            territory = "";
            thema = "";
            label1.Text = territory;
            label2.Text = thema;
            
        }

        private void comboBox_teritory_SelectedIndexChanged(object sender, EventArgs e)
        {
            territory = comboBox_teritory.SelectedItem.ToString();
            button_refresh.Visible = true;
            comboBox_thema.Enabled = true;
            label1.Text = territory;
        }

        private void comboBox_thema_SelectedIndexChanged(object sender, EventArgs e)
        {
            thema = comboBox_thema.SelectedItem.ToString();
            button_start.Visible = true;           
            label2.Text = thema;
        }
        
        private void button_refresh_Click(object sender, EventArgs e)
        {
            button_start.Visible = false;
            comboBox_thema.Enabled = false;
            Init();    
        }

        // Start perform task
        private void button_start_Click(object sender, EventArgs e)
        {
            if (territory == "" || thema == "")
                return;
            undo.Clear();
            redo.Clear();
            cc.VisibleChange(tabControl_instrument, pictureBox_map, label_title,statusStrip);                      
            switch (territory)
            {
                case "Конотопський район":                    
                    pictureBox_map.Image = Image.FromFile("CounterMaps\\Kon_counter.jpg");
                    FirstMap = pictureBox_map.Image;                    
                    break;
                case "Сумський район":
                    pictureBox_map.Image = Image.FromFile("CounterMaps\\Sum_counter.jpg");
                    FirstMap = pictureBox_map.Image;
                    break;
            }
            LoadTask();
            bmp = new Bitmap(pictureBox_map.Image);            
            undo.Push(pictureBox_map.Image);            
            pictureBox_map.Focus();
            counterList = new CounterTaskList(territory, thema, task);
            counterList.Show(); // show list of tasks
        }
        #endregion

        #region Load
        // Load tasks from Data base
        private void LoadTask()
        {
            task.Clear();
            do
            {
                sql.Open();
            }
            while (sql.db_error());
            string query;
            query = "SELECT Location, Thema, Objects FROM CounterMap WHERE Location = '" + territory + "'" + " AND Thema = '" + thema + "'";
            SqlDataReader read;
            do 
            {
                read = sql.Select(query);
            }
            while (sql.db_error());

            while (read.Read())
            {
                task.AddRange(read["Objects"].ToString().Split('*'));                
            }
            do
            {
                sql.Close();
            } 
            while (sql.db_error());                      
        }
        #endregion

        #region Mouse actions       

        private void pictureBox_map_MouseDown(object sender, MouseEventArgs e)
        {
               DrawFlag = true;
               DownX = Convert.ToInt32(e.X);
               DownY = Convert.ToInt32(e.Y);
               bmp = new Bitmap(pictureBox_map.Image);            
               if (draw.txt != null)
               {
                   pictureBox_map.Image = bmp;
                   draw.txt_Leave(draw.txt, e);
                   drawType = DrawType.None;
                   undo.Push(pictureBox_map.Image);
               }
               if (drawType == DrawType.Text)
                   draw.DrawText(DownX, DownY);         
        }

        private void pictureBox_map_MouseMove(object sender, MouseEventArgs e)
        {            
            CurrentX = Convert.ToInt32(e.X);
            CurrentY = Convert.ToInt32(e.Y);
            toolStripStatusLabel_X.Text = CurrentX.ToString();
            toolStripStatusLabel_Y.Text = CurrentY.ToString();
            pen = new Pen(color, (float)numericUpDown_width.Value);
            brush = new SolidBrush(color);
            if (DrawFlag)
            {
                switch (drawType)
                {
                    case DrawType.Rectangle: draw.DrawRectangle(bmp, pen, DownX, DownY, CurrentX, CurrentY);
                        pictureBox_map.Refresh();
                        break;
                    case DrawType.Line: draw.DrawLine(bmp, pen, DownX, DownY, CurrentX, CurrentY);
                        pictureBox_map.Refresh();
                        break;
                    case DrawType.Elipse: draw.DrawElipse(bmp, pen, DownX, DownY, CurrentX, CurrentY);
                        pictureBox_map.Refresh();
                        break;
                    case DrawType.Pen: draw.DrawPen(bmp, pen, ref DownX, ref DownY, CurrentX, CurrentY);
                        pictureBox_map.Refresh();
                        break;
                    case DrawType.Clean: draw.DrawClean(bmp, pen, ref DownX, ref DownY, CurrentX, CurrentY);                        
                        pictureBox_map.Refresh();
                        break;
                    case DrawType.RectangleFill: draw.DrawRectangleFill(bmp, brush, DownX, DownY, CurrentX, CurrentY);
                        pictureBox_map.Refresh();
                        break;
                    case DrawType.EllipseFill: draw.DrawElipseFill(bmp, brush, DownX, DownY, CurrentX, CurrentY);                        
                        pictureBox_map.Refresh();
                        break;
                }              
                
            }            
        }

        private void pictureBox_map_MouseUp(object sender, MouseEventArgs e)
        {
            DrawFlag = false;
            if (drawType == DrawType.Pen || drawType == DrawType.Clean || drawType == DrawType.Elipse || drawType == DrawType.EllipseFill
                || drawType == DrawType.Line || drawType == DrawType.Rectangle || drawType == DrawType.RectangleFill)
                undo.Push(pictureBox_map.Image);
        }
        #endregion

        #region CountourMap Tools

        // Open Color dialog
        private void button_color_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            color = colorDialog.Color;            
        }

        // Change drawtype
        private void ChangeDrawType(object sender)
        {
            Button button = sender as Button;
            switch(button.Name)
            {
                case "button_clean": drawType = DrawType.Clean;
                                     break;
                case "button_pen": drawType = DrawType.Pen;
                                     break;
                case "button_line": drawType = DrawType.Line;
                                     break;
                case "button_rectangle": drawType = DrawType.Rectangle;
                                     break;
                case "button_Elipse": drawType = DrawType.Elipse;
                                     break;
                case "button_text": drawType = DrawType.Text;
                                     break;
                case "button_fill_rectangle": drawType = DrawType.RectangleFill;
                                     break;
                case "button_fill_ellipse": drawType = DrawType.EllipseFill;
                                     break;                
            }            
        }

        // Eraser
        private void Change_Tools_Click(object sender, EventArgs e)
        {            
            ChangeDrawType(sender);
            //this.Cursor = ControlController.LoadCustomCursor("Cursors\\Eraser.cur");
        }

        // Open font dialog
        private void button_shrift_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
        }

        // Clean all changes on counter map
        private void button_mapRefresh_Click(object sender, EventArgs e)
        {
            pictureBox_map.Image = FirstMap;
        }

        // Spill counter map
        private void comboBox_spill_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_spill.SelectedItem.ToString())
            {
                case "Повернути на 90 градусів направо":
                    pictureBox_map.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox_map.Refresh();
                    break;
                case "Повернути на 90 градусів вліво":
                    pictureBox_map.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pictureBox_map.Refresh();
                    break;
                case "Повернтути на 180 градусів":
                    pictureBox_map.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    pictureBox_map.Refresh();
                    break;
            }
        }

        // Show list of tasks
        private void button_show_list_Click(object sender, EventArgs e)
        {
            counterList = new CounterTaskList(territory, thema, task);
            counterList.Show(); // show list of tasks
        }

        // Back to countour map settings
        private void button_countour_back_Click(object sender, EventArgs e)
        {
            Init();
            cc.VisibleChange(tabControl_instrument, pictureBox_map, label_title, statusStrip, button_refresh, button_start);
        }
        #endregion

        #region UndoRedo

        // Undo
        private void button_back_Click(object sender, EventArgs e)
        {           
            if(undo.Count!=1)
            {
                redo.Push(undo.Pop());
                pictureBox_map.Image = undo.Peek();
            }            
        }

        // Redo
        private void button_next_Click(object sender, EventArgs e)
        {
            if(redo.Count!=0)
            {
                pictureBox_map.Image = redo.Peek();
                undo.Push(redo.Pop());
            }           
        }
        #endregion

        #region OpenSavePrint
        // Open countour map
        private void button_open_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "CounterMaps\\";            
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                try
                {
                    pictureBox_map.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Помилка при відкритті зображення!", "Контурні карти",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        // Save countour map
        private void button_save_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("CounterMaps"))
            {
                Directory.CreateDirectory("CounterMaps");
            }

            saveFileDialog_counterMap.InitialDirectory = "CounterMaps\\";
            
            if (saveFileDialog_counterMap.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bmp = (Bitmap)pictureBox_map.Image;
                    if (bmp != null)
                    {
                       
                        bmp.Save(saveFileDialog_counterMap.FileName, ImageFormat.Tiff);
                    }
                    MessageBox.Show("Зображення успішно збережено в папці CounterMaps!", "Контурні карти",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Помилка при збереженні зображення!", "Контурні карти",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                
            else
                return;            
        }

        // Print countour map
        private void button_print_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument Document = new System.Drawing.Printing.PrintDocument();
            Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Document_PrintPage);
            DialogResult result = printDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Document.Print();
            }
        }

        private void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(pictureBox_map.Image), new Point(0, 0)); //Countour map on print
        }
        #endregion      

    }
}
