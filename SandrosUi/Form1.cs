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

namespace SandrosUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("E:\\PUB","*", SearchOption.AllDirectories);

            List<int> skaiciai = new List<int>();

            ListBox.ObjectCollection x = listBox1.Items;

            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
        }
    }
}
