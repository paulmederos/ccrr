using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;


namespace WordCloud
{
    /// <summary>
    /// List of entities, durrr
    /// </summary>
    class EntityList
    {
        #region Variables

        /// <summary>
        /// List of entities, of course.
        /// </summary>
        LinkedList<Entity> entities;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new entity list.
        /// </summary>
        public EntityList()
        {
            entities = new LinkedList<Entity>();
        }

        #endregion

        #region ListAccessFunctions

        /// <summary>
        /// Adds an entity to the list.
        /// </summary>
        /// <param name="newE">Entity to add.</param>
        /// <returns>True if successful, false if entity already in list.</returns>
        public bool addEntity(Entity newE)
        {
            if (entities.Find(newE) != null)
            {
                return false;
            }
            else
            {
                entities.AddLast(newE);
                return true;
            }
        }

        /// <summary>
        /// Adds the filename to the entity. The entity has to already be in the list.
        /// </summary>
        /// <param name="Entity">Name of the entity</param>
        /// <param name="fileName">Filename to add.</param>
        /// <returns>True if the entity was in the list, and the file name was not in the list.</returns>
        public bool addFilename(string entity, string fileName)
        {
            //I have a feeling this isn't going to work.
            Entity foundEn = entities.Find(new Entity(entity, Entity.EntityType.Person)).Value;

            if ( foundEn == null)
            {
                return false;
            }
            else
            {
                return foundEn.addFilename(fileName);
            }
        }

        #endregion

        #region ParsingFunctions

        /// <summary>
        /// Parses the XML file and populates the entity list.
        /// </summary>
        /// <param name="fileName">Filename of the file.</param>
        public void parseFile(string fileName)
        {
            XmlTextReader reader = new XmlTextReader("C:\\dataset\\" + fileName);
            while (reader.Read()) 
            {
                if (reader.NodeType.Equals(XmlNodeType.Element))
                {
                    //The Element tag was just read, we need to
                    // read once more to get the information.
                    switch (reader.Name)
                    {
                        case "reportId":
                            Console.Write("Report ID: ");
                            // Text inside the tags will be read now.
                            reader.Read();
                            Console.WriteLine(reader.Value);
                            break;

                        case "Person":
                            Console.Write("Person: ");
                            reader.Read();
                            Console.WriteLine(reader.Value);
                            break;

                        case "Location":
                            Console.Write("Location: ");
                            reader.Read();
                            Console.WriteLine(reader.Value);
                            break;

                        case "Organization":
                            Console.Write("Organization: ");
                            reader.Read();
                            Console.WriteLine(reader.Value);
                            break;

                        case "Date":
                            Console.Write("Date: ");
                            reader.Read();
                            Console.WriteLine(reader.Value);
                            break;

                        case "Money":
                            Console.Write("Money: ");
                            reader.Read();
                            Console.WriteLine(reader.Value);
                            break;
                    }
                }
                /*switch (reader.NodeType) 
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        while (reader.MoveToNextAttribute()) // Read the attributes.
                        Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine (reader.Value);
                        break;
                    case XmlNodeType. EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }*/
                 
            }
        }

        /// <summary>
        /// Parses XML file and populates the entity list, but only
        /// with files that contain a certian entity.
        /// </summary>
        /// <param name="fileName">Filename of XML file</param>
        /// <param name="EntityName">Name of entity.</param>
        public void parseFile(string fileName, string EntityName)
        {

        }

        #endregion

        #region OtherFunctions

		/// <summary>
		/// Returns a string with the contents of the list.
		/// </summary>
		public string printList()
		{
			string Out = "";

			foreach (Entity cur in entities)
			{
				//Print the name of the entity
				Out += cur.Name + "\r\n";

				foreach(string fN in cur.FileNames)
				{
					Out += "\t";
					Out += fN;
					Out += "\r\n";
				}
			}

			return Out;
		}

        #endregion
    }
}
