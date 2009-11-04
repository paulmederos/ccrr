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
        public DocumentViewUI()
        {
            InitializeComponent(); 
        }

        private void documentListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string term = documentListBox.SelectedItem.ToString();
            
        }
    }
}
