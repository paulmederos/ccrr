using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCloud
{
    /// <summary>
    /// A list of entities, if you can believe it.
    /// </summary>
    class DocumentList
    {
        #region Variables
        /// <summary>
        /// The actual linked list of document objects.
        /// </summary>
        LinkedList<Document> docs;
        #endregion

        #region Constructors

        /// <summary>
        /// Makes a new document list.
        /// </summary>
        public DocumentList()
        {
            docs = new LinkedList<Document>();
        }

        #endregion 

        #region Functions
        
        /// <summary>
        /// Adds a document to docs, returns true if successful, fails if there
        /// is already a document by that name in the list.
        /// <summary>
        public bool addDocument(Document newDoc)
        {
            if (docs.Find(newDoc) = null)
            {
                docs.AddLast(newDoc);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a string with all document names.
        /// </summary>
        public string printList()
        {
            string list;

            foreach (Document doc in docs)
            {
                list += doc.Name + "\r\n";
            }
            return list;
        }

        #endregion

    }
}
