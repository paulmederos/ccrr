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
	public partial class TestForm : Form
	{
		EntityList eList;
        string path = "C:\\Documents and Settings\\Billy Hay\\Desktop\\ccrr\\dataset\\test.xml";

		public TestForm()
		{
			InitializeComponent();
			eList = new EntityList();
            
			string curDir = System.Environment.CurrentDirectory;
			//eList.parseFile(winDir + "\\Stegosaurus-entity-extraction.xml");
            eList.parseFile(path);
		}

		private void testBtn_Click(object sender, EventArgs e)
		{
            testBox.Clear();
			testBox.Text = eList.printList();
            
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Entity toFind = new Entity("Albert Smith", (Entity.EntityType)0);
            LinkedList<Entity> newList = eList.search(toFind, path);
            Console.WriteLine("Search completed, time to display...");
            testBox.Clear();
            string Out = "";
            foreach (Entity cur in newList)
            {
                Out += cur.Name + ": [" + cur.FileNames.Count + "]\r\n";
                
				foreach(Document fN in cur.FileNames)
				{
                    Out += "[in loop]";
					Out += "\t";
                    Out += fN.getName() + " - ";
                    if (fN.getText() != null)
                        Out += "Contains Text";
                    else
                        Out += "NO TEXT";
					Out += "\r\n";
				}
            }

            testBox.Text = Out;

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }



	}
}
