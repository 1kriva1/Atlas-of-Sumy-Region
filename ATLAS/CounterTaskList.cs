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
    public partial class CounterTaskList : Form
    {
        string teritory, thema;
        List<string> list; // task from data base

        public CounterTaskList(string teritory, string thema, List<string> list)
        {
            this.teritory = teritory;
            this.thema = thema;
            this.list = list;
            InitializeComponent();
            Init();
            LoadList();
        }

        private void Init()
        {
            label1.Text = teritory;
            label2.Text = thema;            
        }

        // Show task
        private void LoadList()
        {
            string temp = "Позначити:";
            listBox.Items.Add(temp);
            for (int i = 1; i < list.Count; i++)
            {
                listBox.Items.Add(i.ToString() + ") " + list[(i - 1)] + "\r\n");                
            }            
        }
    }
}
