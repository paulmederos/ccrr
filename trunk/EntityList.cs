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
        public enum EntityType { Person, Location, Organization, Date, Money }

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
        /*public bool addFilename(string entity, string fileName)
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
        */

        #endregion

        #region ParsingFunctions

        /// <summary>
        /// Parses the XML file and populates the entity list.
        /// </summary>
        /// <param name="fileName">Filename of the file.</param>
        public void parseFile(string fileName)
        {
            XmlTextReader reader = new XmlTextReader(fileName);
            string reportId = "";
            string reportDesc = "";
            Document toAdd = new Document("testName", "testText");
            while (reader.Read()) 
            {
                if (reader.NodeType.Equals(XmlNodeType.Element))
                {
                    
                    if (reader.Name.Equals("report"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Starting new report...");
                        reader.Read(); // starts reading the report.
                        reader.Read(); // readers the reportID tag.
                        reader.Read(); // reads the reportID text.
                        reportId = reader.Value;                                              
                    }

                    // These cases are for when it's IN the <report> tag
                    // reading the actual elements.
                    switch (reader.Name)
                    {
                        case "reportDescription":
                            reader.Read();
                            reportDesc = reader.Value;
                            toAdd = new Document(reportId, reportDesc);
                            break;

                        case "Person":
                            // Read the element's value
                            reader.Read();
                            string personName = reader.Value;

                            // Create entity with Person enum (0)
                            Entity newPerson = new Entity(personName, (Entity.EntityType)0);

                            // Add entity to the main entity list if not found already 
                            if (entities.Contains(newPerson)){
                                entities.Find(newPerson).Value.addFilename(toAdd);                              
                            } else {
                                newPerson.addFilename(toAdd);
                                entities.AddLast(newPerson);
                            }
                            break;

                        case "Location":
                            reader.Read();
                            string locName = reader.Value;
                            Entity newLocation = new Entity(locName, (Entity.EntityType)1);
                            if (entities.Contains(newLocation)) {
                                entities.Find(newLocation).Value.addFilename(toAdd);
                            } else{
                            
                                newLocation.addFilename(toAdd);
                                entities.AddLast(newLocation);
                            }                       
                            break;

                        case "Organization":
                            reader.Read();
                            Entity newOrg = new Entity(reader.Value, (Entity.EntityType)2);
                            if (entities.Contains(newOrg))
                            {
                                entities.Find(newOrg).Value.addFilename(toAdd);
                            }
                            else
                            {

                                newOrg.addFilename(toAdd);
                                entities.AddLast(newOrg);
                            }   
                            break;

                        case "Date":
                            reader.Read();
                            Entity newDate = new Entity(reader.Value, (Entity.EntityType)3);
                            if (entities.Contains(newDate))
                            {
                                entities.Find(newDate).Value.addFilename(toAdd);
                            }
                            else
                            {

                                newDate.addFilename(toAdd);
                                entities.AddLast(newDate);
                            }   
                            break;

                        case "Money":
                            reader.Read();
                            Entity newMoney = new Entity(reader.Value, (Entity.EntityType)4);
                            if (entities.Contains(newMoney))
                            {
                                entities.Find(newMoney).Value.addFilename(toAdd);
                            }
                            else
                            {

                                newMoney.addFilename(toAdd);
                                entities.AddLast(newMoney);
                            }   
                            break;
                    }
                }                 
            }
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

			return Out;
		}

        public LinkedList<Entity> getList()
        {
            return entities;
        }

        #endregion
    }
}
