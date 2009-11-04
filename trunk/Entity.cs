using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCloud
{
    /// <summary>
    /// Entity that goes in the entity list.
    /// </summary>
    class Entity
    {
        #region Variables

        /// <summary>
        /// Different types of entities
        /// </summary>
        public enum EntityType { Person, Location, Organization, Date, Money }

        /// <summary>
        /// Type of entity.
        /// </summary>
        EntityType type;

        /// <summary>
        /// Name of entity.
        /// </summary>
        string name;

        /// <summary>
        /// List of files containing the entity.
        /// </summary>
        LinkedList<Document> fileNames;


        #endregion

        #region Functions

        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <param name="eName">Name of the entity</param>
        /// <param name="eType">Type of the entity</param>
        public Entity(string eName, EntityType eType)
        {
            name = eName;
            type = eType;
            fileNames = new LinkedList<Document>();
        }

        /// <summary>
        /// Returns the number of files the entity appears in.
        /// </summary>
        public int hitCount()
        {
            return fileNames.Count;
        }

        /// <summary>
        /// Adds a document to the entity's list of files.
        /// </summary>
        /// <param name="fileName">Name of file to add.</param>
        public bool addFilename(Document file)
        {
            if (fileNames.Find(file) == null)
            {
                fileNames.AddLast(file);
                return true;
            }
            else
            {
                return false;
            }
        }



        #endregion

        #region ListStuff

        /// <summary>
        /// Compares the two entities based on name.
        /// </summary>
        public static bool operator ==(Entity A, Entity B)
        {
            return A.name.Equals(B.name);
        }

        /// <summary>
        /// You know what != does.
        /// </summary>
        public static bool operator !=(Entity A, Entity B)
        {
            return !A.name.Equals(B.name);
        }

        /// <summary>
        /// You know what this does too.
        /// </summary>
        public override bool Equals(object o)
        {
            if (o.GetType().Equals(this.GetType()) )
            {
                Entity other = (Entity)o;
                return name.Equals(other.name);
            }

            return false;
        }

        /// <summary>
        /// Returns a hash code, now we don't get that stupid warning any more.
        /// </summary>
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        

        #endregion

        #region SetGet

        /// <summary>
        /// Type of entity.
        /// </summary>
        public EntityType Type
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// List of files containing this entity.
        /// </summary>
        public List<Document> FileNames
        {
            get
            {
                return new List<Document>(fileNames);
            }
        }

        /// <summary>
        /// Name of the entity.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        #endregion
    }
}
