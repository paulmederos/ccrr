using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCloud
{
    /// <summary>
    /// Document object; holds document name and text
    /// </summary>
    class Document
    {
        #region Variables

        /// <summary>
        /// Name of document.
        /// </summary>
        string name;

        /// <summary>
        /// Text of document.
        /// </summary>
        string text;

        /// <summary>
        /// List of entities in the document.
        /// </summary>
        LinkedList<Entity> entityList;
        #endregion 


        #region Functions

        /// <sumary>
        /// Creates a new document.
        /// </sumary>
        public Document(string docName, string docText)
        {
            name = docName;
            text = docText;
        }

        /// <summary>
        /// Gets text of document.
        /// </summary>
        public string gettext(Document doc)
        {
            return doc.text;
        }

        /// <summary>
        /// Gets name of document.
        /// </summary>
        public string getname(Document doc)
        {
            return doc.name;
        }

        /// <summary>
        /// Adds an entity to the document's entityList.
        /// </summary>
        public bool addEntity(Entity ent)
        {
            if (entityList.Find(ent) == null)
            {
                entityList.AddLast(ent);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
