﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

			StreamReader In = new StreamReader(fileName);

			string curFile = ""; //Current file data is being read for
			string curLine = ""; //Current line in the XML file

			while (In.EndOfStream == false)
			{
				//Go until you find out the filename
				while (curFile == "")
				{
					curLine = In.ReadLine();

					
				}


				//Now keep going to the end

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
