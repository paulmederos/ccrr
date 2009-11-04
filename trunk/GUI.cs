﻿using System;
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
		EntityList eList;
		bool dataLoaded;
		LinkedList<Entity> burstList;
		int listTrim;
		string curSearchTerm;

        public GUI()
        {
            InitializeComponent();
			d = new Docuburst(BurstPanel);
			eList = new EntityList();
			burstList = new LinkedList<Entity>();
			listTrim = 20;
			dataLoaded = false;
        }

        private void searchButton_MouseClick(object sender, MouseEventArgs e)
        {
            previousSearchBox.Items.Insert(0, searchBox.Text);
        }

		/// <summary>
		/// Double buffered panel
		/// </summary>
		public class MyPanel : Panel
		{
			public MyPanel()
				: base()
			{
				this.DoubleBuffered = true;
			}
		}

		private void BurstPanel_Paint(object sender, PaintEventArgs e)
		{

			d.unleashDocuburst(e);
		}

		private void GUI_Resize(object sender, EventArgs e)
		{
			d.SetSize();
			Refresh();
		}

		private void BurstPanel_MouseMove(object sender, MouseEventArgs e)
		{
			d.mouseMove(e);
			Refresh();
		}

		private void BurstPanel_MouseDown(object sender, MouseEventArgs e)
		{
			Entity hit = d.mouseClick(e);


		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult res = openFileDialog1.ShowDialog();

			if (res == DialogResult.OK)
			{
				string fileName = openFileDialog1.FileName;

				eList.parseFile(fileName);

				curSearchTerm = "";
				burstList = eList.getList();
				LinkedList<Entity> trimmedList = trimEntityList(burstList, listTrim);
				d.Populate(trimmedList, curSearchTerm);
				
				dataLoaded = true;
			}
		}

		private void showPerson_CheckedChanged(object sender, EventArgs e)
		{
			LinkedList<Entity> trimmedList = trimEntityList(burstList, listTrim);
			d.Populate(trimmedList, curSearchTerm);
			Refresh();
		}

		private void showLocation_CheckedChanged(object sender, EventArgs e)
		{
			LinkedList<Entity> trimmedList = trimEntityList(burstList, listTrim);
			d.Populate(trimmedList, curSearchTerm);
			Refresh();
		}

		private void showOrganization_CheckedChanged(object sender, EventArgs e)
		{
			LinkedList<Entity> trimmedList = trimEntityList(burstList, listTrim);
			d.Populate(trimmedList, curSearchTerm);
			Refresh();
		}

		private void showMoney_CheckedChanged(object sender, EventArgs e)
		{
			LinkedList<Entity> trimmedList = trimEntityList(burstList, listTrim);
			d.Populate(trimmedList, curSearchTerm);
			Refresh();
		}

		private void showDate_CheckedChanged(object sender, EventArgs e)
		{
			LinkedList<Entity> trimmedList = trimEntityList(burstList, listTrim);
			d.Populate(trimmedList, curSearchTerm);
			Refresh();
		}


		/// <summary>
		/// Trims a list of entities and returns a new one.
		/// </summary>
		/// <param name="list"></param>
		/// <param name="minHits"></param>
		private LinkedList<Entity> trimEntityList(LinkedList<Entity> list, int maxWedges)
		{
			//Return early if possible
			if (list.Count <= maxWedges)
				return list;

			LinkedList<Entity> newList = new LinkedList<Entity>();

			foreach (Entity cur in list)
			{

				if (isEntityShown(cur.Type))
				{
					LinkedListNode<Entity> curNode = newList.First;

					if (curNode == null)
					{
						newList.AddFirst(cur);
					}
					else
					{
						while (curNode.Value.hitCount() < cur.hitCount())
						{
							curNode = curNode.Next;


							if (curNode == newList.Last)
							{
								break;
							}
						}

						if (cur.hitCount() < curNode.Value.hitCount())
						{
							newList.AddBefore(curNode, cur);
						}
						else
						{
							newList.AddAfter(curNode, cur);
						}

						if (newList.Count >= maxWedges)
						{
							newList.RemoveFirst();
						}
					}
				}
			}

			return newList;
		}

		private bool isEntityShown(Entity.EntityType typ)
		{
			switch (typ)
			{
				case Entity.EntityType.Person:
					return showPerson.Checked;
				case Entity.EntityType.Organization:
					return showOrganization.Checked;
				case Entity.EntityType.Money:
					return showMoney.Checked;
				case Entity.EntityType.Location:
					return showLocation.Checked;
				case Entity.EntityType.Date:
					return showDate.Checked;
			}
			return true;
		}

    }
}