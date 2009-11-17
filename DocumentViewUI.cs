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
        LinkedList<Document> docList;


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
                documentListBox.Items.Add(doc.name);
            }

            docList = GUI.curSearchTerm.fileNames;
        }

        private void documentListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void documentListBox_Click(object sender, EventArgs e)
        {
            Document selectedDoc = new Document("BLANK", "BLANK");
            foreach (Document cur in docList)
            {
                if (cur.name == (string)documentListBox.SelectedItem)
                {
                    selectedDoc = cur;
                    break;
                }
            }
            textBox1.Text = selectedDoc.text;
        }

        private void documentListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            documentListBox_Click(sender, e);
        }
    }
}
