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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void documentButton_Click(object sender, EventArgs e)
        {
            documentList.Items.Insert(0, documentBox.Text);
        }

        private void perpButton_Click(object sender, EventArgs e)
        {
            perpList.Items.Insert(0, perpBox.Text);
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
