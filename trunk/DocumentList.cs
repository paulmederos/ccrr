using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCloud
{
    /// <summary>
    /// A list of documents, if you can believe it.
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
        /// Returns a string with all document names.
        /// </summary>
        public string printList()
        {
            string list="";

            foreach (Document doc in docs)
            {
                list += doc.getName() + "\r\n";
            }
            return list;
        }

        #endregion

    }
}
