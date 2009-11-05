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
    public partial class DocumentViewUI : Form
    {
        Document curr_doc;


        public DocumentViewUI()
        {
            InitializeComponent();
            entityLabel.Text = "No Entity Selected.";
        }

        public DocumentViewUI(Entity curEntity)
        {
            InitializeComponent();
            entityLabel.Text = curEntity.Name;
            foreach (Document doc in curEntity.fileNames)
            {
                documentListBox.Items.Add(doc);
            }
        }

        private void documentListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void documentListBox_Click(object sender, EventArgs e)
        {
            string term = documentListBox.SelectedItem.ToString();
            curr_doc = (Document)documentListBox.SelectedItem;
            this.textBox1.Text = curr_doc.text;
        }

        private void documentListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            documentListBox_Click(sender, e);
        }
    }
}
