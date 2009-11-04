using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace WordCloud
{
    public partial class GUI : Form
    {
        Docuburst d;
		EntityList eList;        
		bool dataLoaded;
		LinkedList<Entity> burstList;
		int listTrim;
		public Entity curSearchTerm;
        string globalFileName; //Path for XML file.

        public GUI()
        {
            InitializeComponent();
			d = new Docuburst(BurstPanel);
			eList = new EntityList();
			burstList = new LinkedList<Entity>();
			listTrim = 20;
			dataLoaded = false;

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
			if (hit.Name != "NOTHING")
			{
				curSearchTerm = eList.getEntity(hit.Name);
				burstList = eList.search(curSearchTerm, globalFileName);
				refreshList();
				previousSearchBox.Items.Insert(0, hit.Name);

				SoundPlayer s = new SoundPlayer();

				string curDir = System.Environment.CurrentDirectory;
				s.SoundLocation = curDir + "\\boom.wav";
				s.Play();
			}
		}


		private void searchButton_Click_1(object sender, EventArgs e)
		{
			if (eList.containsEntity(searchBox.Text))
			{
				curSearchTerm = eList.getEntity(searchBox.Text);
				burstList = eList.search(curSearchTerm, globalFileName);
				refreshList();
				previousSearchBox.Items.Insert(0, searchBox.Text);
			}
			else
			{
				MessageBox.Show("Damn, we don't have that entity in our list!", "Name Entry Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}


		private void previousSearchBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string term = previousSearchBox.SelectedItem.ToString();
			if (eList.containsEntity(term))
			{
				curSearchTerm = eList.getEntity(term);
				burstList = eList.search(curSearchTerm, globalFileName);
				refreshList();
				//previousSearchBox.Items.Insert(0, searchBox.Text);
				
			}
			else
			{
				MessageBox.Show("Damn, we don't have that entity in our list!", "Name Entry Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult res = openFileDialog1.ShowDialog();

			if (res == DialogResult.OK)
			{

				burstList = new LinkedList<Entity>();
				eList = new EntityList();

				globalFileName = openFileDialog1.FileName;

				eList.parseFile(globalFileName);

				curSearchTerm = new Entity("",Entity.EntityType.Date);
				burstList = eList.getList();
				
				refreshList();
				
				dataLoaded = true;
			}
		}

		private void showPerson_CheckedChanged(object sender, EventArgs e)
		{
			refreshList();
		}

		private void showLocation_CheckedChanged(object sender, EventArgs e)
		{
			refreshList();
		}

		private void showOrganization_CheckedChanged(object sender, EventArgs e)
		{
			refreshList();
		}

		private void showMoney_CheckedChanged(object sender, EventArgs e)
		{
			refreshList();
		}

		private void showDate_CheckedChanged(object sender, EventArgs e)
		{
			refreshList();
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

				if (isEntityShown(cur.Type) && cur.Name != curSearchTerm.Name)
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


							if (curNode == null || curNode == newList.Last)
							{
								break;
							}
						}

						if (curNode != null)
						{
							if (cur.hitCount() < curNode.Value.hitCount())
							{
								newList.AddBefore(curNode, cur);
							}
							else
							{
								newList.AddAfter(curNode, cur);
							}
						}
						else
						{
							newList.AddLast(cur);
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


		private void wedgesSlider_Scroll(object sender, EventArgs e)
		{
			listTrim = wedgesSlider.Value;
			refreshList();
		}

		private void refreshList()
		{
			LinkedList<Entity> trimmedList = trimEntityList(burstList, listTrim);

			d.Populate(trimmedList, curSearchTerm.Name);

			string labelText = "Entities shown:" + trimmedList.Count.ToString() + " of "
				+ burstList.Count.ToString();
			NumEntitiesLabel.Text = labelText;

			Refresh();
		}

		private void homeButton_Click(object sender, EventArgs e)
		{
			curSearchTerm = new Entity("", Entity.EntityType.Date);
			burstList = eList.getList();

			refreshList();
		}

    }
}
