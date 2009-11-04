using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordCloud
{
    public partial class GUI : Form
    {
        Docuburst d;

        public GUI()
        {
            InitializeComponent();
            d = new Docuburst(docuBurstPanel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void searchButton_MouseClick(object sender, MouseEventArgs e)
        {
            previousSearchBox.Items.Insert(0, searchBox.Text);
        }
    }
}
