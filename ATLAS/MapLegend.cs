using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLAS
{
    public partial class MapLegend : Form
    {
        public MapLegend()
        {
            InitializeComponent();
        }

        public void LoadLegend(string part, string map)
        {
            try
            {
                pictureBox_MapLegend.Image = Image.FromFile("MapLegends\\" + part + "\\" + map + "Legend" + ".tif");
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Дані тимчасово відсутні!", "Атлас вибачається", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MapLegend_FormClosed(object sender, FormClosedEventArgs e)
        {
            Atlas_Main.ml = null;
        }
    }
}
