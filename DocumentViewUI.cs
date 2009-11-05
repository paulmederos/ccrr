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
            documentListBox.Items.AddRange(GUI.curSearchTerm.fileNames.ToArray() );
        }

        private void documentListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string term = documentListBox.SelectedItem.ToString();
            curr_doc = (Document)documentListBox.SelectedItem;
            this.textBox1.Text = curr_doc.text;
        }
    }
}
