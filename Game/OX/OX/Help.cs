using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OX
{
    class Help
    {       
        public void show_rules()
        {
            MessageBox.Show("Перемогу в грі здобуває той, хто зміг першим скласти лінію (вертикально або горизонтально або по діагоналі) з трьох символів. Першим завжди починає ходити крестик.", "Правила гри" );
        }

        public void show_about()
        {
            MessageBox.Show("Автор Андрій Криворук", "Інформація про гру");
        }
    }
}
