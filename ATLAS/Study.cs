using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLAS
{
    class Study
    {
        // Load study information
        public Image LoadThema(string location, string thema="Common")
        {
            try
            {
                return Image.FromFile("Study\\" + thema + "\\" + location + ".tif"); 
            }
            catch
            {
                MessageBox.Show("Дані тимчасово відсутні!", "Атлас вибачається", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }                  
        }

        // Load Title statistic information
        public Image LoadStat(string location)
        {
            try
            {
                return Image.FromFile("Title\\" + location + ".tif");
            }
            catch
            {
                MessageBox.Show("Дані тимчасово відсутні!", "Атлас вибачається", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }                            
        }
    }
}
