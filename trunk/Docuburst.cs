using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WordCloud
{
    class Docuburst
    {
        #region PetalClass

        /// <summary>
        /// Class that represents a single wedge of the burst
        /// </summary>
        private class Petal
        {
            public Entity entity;

            public double startAngle;
            public double endAngle;
            public int radius;

            public double textAngle;
            public bool textFlip;
            public Point textPos;

            public bool selected;

            public Petal()
            {
                entity = null;
                startAngle = 0;
                endAngle = 0;
                radius = 0;
                textAngle = 0;
                textFlip = false;
                textPos = new Point();
                selected = false;
            }
        }

        #endregion

        #region Variables

        /// <summary>
        /// List of petals
        /// </summary>
        LinkedList<Petal> petals;

        /// <summary>
        /// Panel the burst should be drawn on.
        /// </summary>
        GUI.MyPanel parentPanel;

        /// <summary>
        /// Text that appears in the center circle.
        /// </summary>
        string searchTerm;

        /// <summary>
        /// Center point of the parent panel.
        /// </summary>
        Point panelCenter;

        /// <summary>
        /// Radius of the center circle.
        /// </summary>
        int circleRad;

        /// <summary>
        /// Size of the smalled petal.
        /// </summary>
        int minPetalRad;

        /// <summary>
        /// Size of the largest petal.
        /// </summary>
        int maxPetalRad;

        /// <summary>
        /// Number of petals currently in the docuburst
        /// </summary>
        int numPetals;

        /// <summary>
        /// Angular size of each petal.
        /// </summary>
        double petalAngle;


        #endregion

        #region Functions

        #region Constructors

        /// <summary>
        /// Create a docuburst.
        /// </summary>
        /// <param name="parent">Form the burst should appear in. </param>
        public Docuburst(GUI.MyPanel parent)
        {
            petals = new LinkedList<Petal>();
            parentPanel = parent;
            searchTerm = "";

            panelCenter = new Point();
            circleRad = 0;
            minPetalRad = 0;
            maxPetalRad = 0;
            numPetals = 0;
        }

        #endregion

        #region Modification

        /// <summary>
        /// Resets the size of the docuburst.
        /// </summary>
        public void SetSize()
        {
            #region Set up general scaling variables

            panelCenter = new Point(parentPanel.Width / 2, parentPanel.Height / 2);

            //Get the smaller of the two dimensions of the panel
            int minDim = parentPanel.Width;
            if (parentPanel.Height < parentPanel.Width) minDim = parentPanel.Height;

            int maxRad = (int)((float)minDim / 2.0f);

            //Set sizes of circle and petals
            circleRad = (int)((double)maxRad * 0.15);
            minPetalRad = (int)((double)maxRad * 0.35);
            maxPetalRad = maxRad;

            //Number of petals to appear in burst
            numPetals = petals.Count;

            //Decide angle of petals
            if (numPetals <= 10)
            {
                petalAngle = Math.PI / 5;
            }
            else
            {
                petalAngle = (2 * Math.PI) / numPetals;
            }


            #endregion

            int minHits;
            int maxHits;

            #region Get minimum and maximum number of hits

            //Initially....
            minHits = 9999;
            maxHits = -9999;

            foreach (Petal cur in petals)
            {
                int curHits = cur.entity.hitCount();
                if (curHits > maxHits) maxHits = curHits;
                if (curHits < minHits) minHits = curHits;
            }

            #endregion           

            #region Set up each petal

            int petalNum = 0;

            foreach (Petal cur in petals)
            {
                #region Decide petal size

                int petalSizeDif = maxPetalRad - minPetalRad;

                //TYPE CASTING!!!!
                double petalSizeRatio = ((double)(cur.entity.hitCount() - minHits)) / ((double)(maxHits));

                cur.radius = minPetalRad + (int)((double)petalSizeDif * petalSizeRatio);

                #endregion

                #region Decide petal's angles

                cur.startAngle = petalNum * petalAngle;
                cur.endAngle = (petalNum + 1) * petalAngle;

                #endregion

                #region Position text

                #region Calculate Angle

                cur.textAngle = (cur.startAngle + cur.endAngle) / 2.0;

                if (cur.textAngle > Math.PI / 2 && cur.textAngle < Math.PI / 2 * 3)
                {
                    cur.textAngle += Math.PI;
                    if (cur.textAngle > 2 * Math.PI) cur.textAngle -= 2 * Math.PI;
                    cur.textFlip = true;
                }

                #endregion

                #region Calculate text position

                float txtStartRad = (float)maxRad * 0.2f;
                float txtEndRad = (float)cur.radius * 0.85f;

                if (!cur.textFlip)
                {
                    cur.textPos.X = (int)((double)panelCenter.X + (double)txtStartRad * Math.Cos(cur.textAngle));
                    cur.textPos.Y = (int)((double)panelCenter.Y + (double)txtStartRad * Math.Sin(cur.textAngle));
                }
                else
                {
                    cur.textPos.X = (int)((double)panelCenter.X - (double)txtEndRad * Math.Cos(cur.textAngle));
                    cur.textPos.Y = (int)((double)panelCenter.Y - (double)txtEndRad * Math.Sin(cur.textAngle));
                }

                #endregion


                #endregion

                petalNum++;
            }

            #endregion
        }

        /// <summary>
        /// Re-makes the docuburst with the list of entities.
        /// </summary>
        /// <param name="entities">List used to form burst.</param>
        /// <param name="search">Tag burst was created from.</param>
        public void Populate(LinkedList<Entity> entities, string search)
        {
            searchTerm = search;

			//Reset
			petals.Clear();
			numPetals = 0;

			//Now populate
            foreach (Entity curEn in entities)
            {
                Petal curPetal = new Petal();
                curPetal.entity = curEn;
                petals.AddFirst(curPetal);
            }

            //List sorting goes here.

            SetSize();
        }

        #endregion

        #region Drawing

        /// <summary>
        /// Unleashes the docuburst.
        /// </summary>
        /// <param name="e">Drawing argument thing</param>
        public void unleashDocuburst(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            #region Draw petals

            foreach (Petal cur in petals)
            {
                Point[] polyPoints = new Point[4];

                Color PetalColor = getColor(cur.entity.Type, cur.selected);
                int borderSize = 2;
                if (cur.selected)
                    borderSize = 4;

                #region Define Polygon

                polyPoints[0] = new Point(panelCenter.X + (int)((double)circleRad * Math.Cos(cur.startAngle)),
                    panelCenter.Y + (int)((double)circleRad * Math.Sin(cur.startAngle)));

                polyPoints[1] = new Point(panelCenter.X + (int)((double)cur.radius * Math.Cos(cur.startAngle)),
                    panelCenter.Y + (int)((double)cur.radius * Math.Sin(cur.startAngle)));

                polyPoints[2] = new Point(panelCenter.X + (int)((double)cur.radius * Math.Cos(cur.endAngle)),
                    panelCenter.Y + (int)((double)cur.radius * Math.Sin(cur.endAngle)));

                polyPoints[3] = new Point(panelCenter.X + (int)((double)circleRad * Math.Cos(cur.endAngle)),
                    panelCenter.Y + (int)((double)circleRad * Math.Sin(cur.endAngle)));

                #endregion

                g.FillPolygon(new SolidBrush(PetalColor), polyPoints);
                g.DrawPolygon(new Pen(Color.Black, borderSize), polyPoints);

                #region Draw Text

                float textScale = 1;
                Font font = new Font(FontFamily.GenericSansSerif, 12);

                #region Calculate text size

                float txtStartRad = (float)circleRad * 1.2f;
                float txtEndRad = (float)cur.radius * 0.85f;

                SizeF baseTextSize = g.MeasureString(cur.entity.Name, font);
                textScale = (txtEndRad - txtStartRad) / baseTextSize.Width;

                #endregion


                g.TranslateTransform(cur.textPos.X, cur.textPos.Y);
                g.RotateTransform((float)((cur.textAngle / Math.PI) * 180.0));
                g.ScaleTransform(textScale, textScale);
                g.DrawString(cur.entity.Name, font, Brushes.Black, new RectangleF(0,(-1 * textScale * baseTextSize.Height) / 4.0f,9999, 9999));
                g.ResetTransform();

                #endregion
            }

            #endregion

            #region DrawCenterCircle

            Rectangle circRect = new Rectangle(panelCenter.X - circleRad, panelCenter.Y - circleRad,
                circleRad * 2, circleRad * 2);
            g.FillEllipse(Brushes.LightBlue, circRect);
            g.DrawEllipse(new Pen(Color.Black, 3), circRect);

            Font cfont = new Font(FontFamily.GenericSansSerif, 12);
            SizeF baseCircTextSize = g.MeasureString(searchTerm,cfont);
            float circTextScale = ((float)circleRad * 1.8f) / baseCircTextSize.Width;

            g.TranslateTransform(panelCenter.X - ((circTextScale * baseCircTextSize.Width) / 2.0f), 
                panelCenter.Y - ((circTextScale * baseCircTextSize.Height) / 2.0f) );
            g.ScaleTransform(circTextScale, circTextScale);
            g.DrawString(searchTerm, cfont , Brushes.Black, new PointF(0,0) );

            #endregion
        }

        /// <summary>
        /// Returns the color of a type in the docuburst.
        /// </summary>
        private Color getColor(Entity.EntityType type, bool selected)
        {
            switch (type)
            {
                case Entity.EntityType.Person:
                    if (selected)
                    {
                        return Color.FromArgb(255, 255, 208, 150);
                    }
                    else
                    {
                        return Color.FromArgb(255, 255, 158, 80);
                    }
                case Entity.EntityType.Organization:
                    if (selected)
                    {
                        return Color.FromArgb(255, 178, 178, 250);
                    }
                    else
                    {
                        return Color.FromArgb(255, 128, 128, 200);
                    }
                case Entity.EntityType.Money:
                    if (selected)
                    {
                        return Color.FromArgb(255, 200, 255, 200);
                    }
                    else
                    {
                        return Color.FromArgb(255, 150, 220, 150);
                    }
                case Entity.EntityType.Location:
                    if (selected)
                    {
                        return Color.FromArgb(255, 255, 255, 200);
                    }
                    else
                    {
                        return Color.FromArgb(255, 235, 235, 150);
                    }
                case Entity.EntityType.Date:
                    if (selected)
                    {
                        return Color.FromArgb(255, 230, 230, 230);
                    }
                    else
                    {
                        return Color.FromArgb(255, 180, 180, 180);
                    }
				default:
					if (selected)
					{
						return Color.FromArgb(255, 130, 230, 230);
					}
					else
					{
						return Color.FromArgb(255, 100, 190, 190);
					}
            }
            //return Color.Red;
        }

        #endregion

        #region Interaction

        /// <summary>
        /// Called whenever the mouse moves and decides which petal is selected
        /// </summary>
        public void mouseMove(MouseEventArgs e)
        {
            //Get mouse's offset from center point
            double mouseXOffset = (double)(e.X - panelCenter.X);
            double mouseYOffset = (double)(e.Y - panelCenter.Y);

            //Decide what angle the mouse is at relative to the center of the form.
            double mouseAngle = Math.Atan2(mouseYOffset, mouseXOffset);
            if (mouseAngle < 0) mouseAngle += 2 * Math.PI;

            //Decide what radius the mouse is at.
            double mouseRad = Math.Sqrt(Math.Pow(mouseXOffset, 2) + Math.Pow(mouseYOffset, 2));

            //Now loop through petals and see if it hits any.
            foreach (Petal cur in petals)
            {
                if (mouseAngle >= cur.startAngle && mouseAngle < cur.endAngle)
                {
                    if (mouseRad > circleRad && mouseRad < cur.radius)
                    {
                        cur.selected = true;
                    }
                    else
                    {
                        cur.selected = false;
                    }
                }
                else
                {
                    cur.selected = false;
                }
            }

        }

        /// <summary>
        /// Returns which entity is being clicked. Returns an entity named
        /// NOTHING if nothing was clicked
        /// </summary>
        public Entity mouseClick(MouseEventArgs e)
        {
            foreach (Petal cur in petals)
            {
                if (cur.selected)
                {
                    return cur.entity;
                }
            }


            Entity nothing = new Entity("NOTHING", Entity.EntityType.Money);
            return nothing;
        }

        #endregion

        #endregion
    }
}
