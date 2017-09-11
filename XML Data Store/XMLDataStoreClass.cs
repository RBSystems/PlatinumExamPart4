// <copyright file="XMLDataStoreClass.cs" company="Avspire Ltd.">
// Copyright (c) Avspire Ltd. All rights reserved.
// </copyright>

namespace XMLDataStore
{
    using System;

    using Crestron.SimplSharp;
    using Crestron.SimplSharp.CrestronXml.Serialization;

    /// <summary>
    /// Write xml tot a file and then read it back...
    /// </summary>
    public class XMLDataStoreClass
    {
        /// <summary>
        /// Write then read some data
        /// </summary>
        public void XmlWriteReadData()
        {
            // Create a new book
            Book b = new Book();

            b.Title = "Serialization Overview";
            b.Author = "Some Guy";
            b.WordCount = 3;
            b.StarRating = 5;
            b.Text = "Lots of text";

            // Serialize it to a file
            CrestronXMLSerialization.SerializeObject("\\NVRAM\\XmFile.xml", b);

            // Read it back
            Book b2 = CrestronXMLSerialization.DeSerializeObject<Book>("\\NVRAM\\XmFile.xml");

            // Print to console
            CrestronConsole.PrintLine("Title: {0}", b2.Title);
            CrestronConsole.PrintLine("Author: {0}", b2.Author);
            CrestronConsole.PrintLine("Word Count: {0}", b2.WordCount);
            CrestronConsole.PrintLine("Star Rating: {0}", b2.StarRating);
            CrestronConsole.PrintLine("Text: {0}", b2.Text);
        }

        /// <summary>
        /// A class representing a book
        /// </summary>
        public class Book
        {
            /// <summary>
            /// Initializes a new instance of the Book class
            /// </summary>
            public Book()
            {
                this.Title = string.Empty;
                this.Author = string.Empty;
                this.Text = string.Empty;
            }

            /// <summary>
            /// Gets or sets the title of the book
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            /// Gets or sets the author of the book
            /// </summary>
            public string Author { get; set; }

            /// <summary>
            /// Gets or sets the word count of the book
            /// </summary>
            public int WordCount { get; set; }

            /// <summary>
            /// Gets or sets the star rating of the book
            /// </summary>
            public int StarRating { get; set; }

            /// <summary>
            /// Gets or sets the text of the book
            /// </summary>
            public string Text { get; set; }
        }
    }
}