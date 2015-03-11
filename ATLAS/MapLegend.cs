using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            pictureBox_MapLegend.Image = Image.FromFile("MapLegends\\" + part + "\\" + map + "Legend" + ".tif");
        }
    }
}
