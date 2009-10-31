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
	public partial class Form1 : Form
	{
		EntityList eList;


		public Form1()
		{
			InitializeComponent();
			eList = new EntityList();

			string winDir = System.Environment.GetEnvironmentVariable("windir");
			//eList.parseFile(winDir + "\\Stegosaurus-entity-extraction.xml");
            eList.parseFile("Stegosaurus-entity-extraction.xml");
		}

		private void testBtn_Click(object sender, EventArgs e)
		{
			testBox.Text = eList.printList();
		}



	}
}
