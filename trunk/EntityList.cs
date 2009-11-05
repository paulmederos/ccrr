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
        int numEntities;
        public enum EntityType { Person, Location, Organization, Date, Money }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new entity list.
        /// </summary>
        public EntityList()
        {
            entities = new LinkedList<Entity>();
            numEntities = 0;
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

        public Entity getEntity(string toFind)
        {
            return entities.Find(new Entity(toFind, (Entity.EntityType)0)).Value;
        }

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
                            numEntities++;
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
                            numEntities++;
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
                            numEntities++;
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
                            numEntities++;
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
                            numEntities++;
                            break;
                    }
                }                 
            }
        }

        /// <summary>
        /// Searches through the main database for Entities that are
        /// in the same document as the Entity we are searching for.
        /// </summary>
        /// <param name="toFind">Entity we are finding associations for</param>
        /// <returns>New list with associations</returns>
        public LinkedList<Entity> search(Entity toFind, string fileName)
        {
            LinkedList<Entity> newList = new LinkedList<Entity>();
            
            
            XmlTextReader reader = new XmlTextReader(fileName);
            string reportId = "";
            string reportDesc = "";
            Document toAdd = new Document("testName", "testText");
            bool shouldScan = false;

            // Time to go through the XML again...
            while (reader.Read())
            {
                // If we just read an Element tag...
                if (reader.NodeType.Equals(XmlNodeType.Element))
                {
                    // If Element tag shows we're in a new report...
                    if (reader.Name.Equals("report"))
                    {
                        reader.Read(); // starts reading the report.
                        reader.Read(); // readers the reportID tag.
                        reader.Read(); // reads the reportID text.
                        reportId = reader.Value;
                        

                        // Make sure we are in a document that is associated with 
                        // current Entity we are searching for.
                        foreach (Document doc in entities.Find(toFind).Value.FileNames)
                        {
                            if (doc.getName() == reportId)
                            {
                                shouldScan = true;
								break;
                            }
                            else
                            {
                                shouldScan = false;
                            }
                        }
                    }

                    // Check to see what the current Tag is.
                    switch (reader.Name)
                    {
                        case "reportDescription":
                            if (shouldScan)
                            {
                                reader.Read();
                                reportDesc = reader.Value;
                                toAdd = new Document(reportId, reportDesc);
                            }
                            break;

                        case "Person":
                            if (shouldScan)
                            {
                                // Read the element's value
                                reader.Read();
                                string personName = reader.Value;

                                // Create entity with Person enum (0)
                                Entity newPerson = new Entity(personName, (Entity.EntityType)0);

                                // Add entity to the main entity list if not found already 
                                if (newList.Contains(newPerson))
                                {
                                    newList.Find(newPerson).Value.addFilename(toAdd);
                                }
                                else
                                {
                                    newPerson.addFilename(toAdd);
                                    newList.AddLast(newPerson);
                                }
                                
                            }
                            break;

                        case "Location":
                            if (shouldScan)
                            {
                                reader.Read();
                                string locName = reader.Value;
                                Entity newLocation = new Entity(locName, (Entity.EntityType)1);
                                if (newList.Contains(newLocation))
                                {
                                    newList.Find(newLocation).Value.addFilename(toAdd);
                                }
                                else
                                {

                                    newLocation.addFilename(toAdd);
                                    newList.AddLast(newLocation);
                                }
                                
                            }
                            break;

                        case "Organization":
                            if (shouldScan)
                            {
                                reader.Read();
                                Entity newOrg = new Entity(reader.Value, (Entity.EntityType)2);
                                if (newList.Contains(newOrg))
                                {
                                    newList.Find(newOrg).Value.addFilename(toAdd);
                                }
                                else
                                {
                                    newOrg.addFilename(toAdd);
                                    newList.AddLast(newOrg);
                                }
                                
                            }
                            break;

                        case "Date":
                            if (shouldScan)
                            {
                                reader.Read();
                                Entity newDate = new Entity(reader.Value, (Entity.EntityType)3);
                                if (newList.Contains(newDate))
                                {
                                    newList.Find(newDate).Value.addFilename(toAdd);
                                }
                                else
                                {
                                    newDate.addFilename(toAdd);
                                    newList.AddLast(newDate);
                                }
                                
                            }
                            break;

                        case "Money":
                            if (shouldScan)
                            {
                                reader.Read();
                                Entity newMoney = new Entity(reader.Value, (Entity.EntityType)4);
                                if (newList.Contains(newMoney))
                                {
                                    newList.Find(newMoney).Value.addFilename(toAdd);
                                }
                                else
                                {
                                    newMoney.addFilename(toAdd);
                                    newList.AddLast(newMoney);
                                }
                                
                            }
                            break;
                    }                                    
                }
            }
            return newList;
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

        public int numOfEntities()
        {
            return numEntities;
        }

        public bool containsEntity(string word)
        {
            Entity find = new Entity(word, (Entity.EntityType)0);
            return entities.Contains(find);
        }

        #endregion
    }
}
