using ATLAS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLAS
{
    public partial class ScreenShotsViewer : Form
    {
        FileStream fs;

        public ScreenShotsViewer()
        {
            InitializeComponent();
            Init();
        }

        // Load all screenshots in listbox
        private void Init()
        {
            char[] mass = { '.', 't', 'i', 'f' };
            listBox_screenshots.Items.Clear();
            DirectoryInfo di = new DirectoryInfo("Screenshots\\");
            FileInfo[] info = di.GetFiles();

            foreach (FileInfo f in info)
            {
                string name = f.ToString().TrimEnd(mass);
                listBox_screenshots.Items.Add(name);
            }
        }

        // Delete screenshots
        private void button_delete_Click(object sender, EventArgs e)
        {                                           
            try
            {
                fs.Dispose();                
                File.Delete("Screenshots\\" + listBox_screenshots.SelectedItem.ToString() + ".tif");
                MessageBox.Show("Зображення успішно видалено!", "Screenshots",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                Init();
                pictureBox_screenshot.Image = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка при видаленні зображення!", "Screenshots",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Show screenshots when change index in listbox
        private void listBox_screenshots_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                using(fs = new FileStream("Screenshots\\" + listBox_screenshots.SelectedItem.ToString() + ".tif", FileMode.Open))
                {
                    pictureBox_screenshot.Image = Image.FromStream(fs);
                }
                
                //pictureBox_screenshot.Image = Image.FromFile("Screenshots\\" + listBox_screenshots.SelectedItem.ToString() + ".tif");                
                button_delete.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка при завантаженні зображення!", "Screenshots",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

       
    }
}
