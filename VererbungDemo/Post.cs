using System;
using System.Collections.Generic;
using System.Text;

namespace VererbungDemo
{
    class Post
    {
        private static int currentPostId;

        // Eigenschaften / Properties
        protected int ID { get; set; }
        protected string Title  { get; set; }
        protected string SentByUserName  { get; set; }
        protected bool IsPublic  { get; set; }


        // Default Konstruktor
        public Post() 
        {
            ID = 0;
            Title = "Mein erster Post";
            IsPublic = true;
            SentByUserName = "John";
        }
        
        public Post(string title, bool isPublic, string sentByUsername) 
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUserName = sentByUsername;
            this.IsPublic = isPublic;
        }

        // Virtual Methoden können von erbenden klassen überschrieben werden
        public override string ToString()
        {
            return String.Format("{0} - {1} - von {2}", this.ID, this.Title, this.SentByUserName);
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        
        
        protected int GetNextID() 
        {
            return ++currentPostId;
        }





    }
}
