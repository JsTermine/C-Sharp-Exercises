using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace VererbungDemo
{

    // ImagePost erbt von Post und fügt eine Eigenschaft (ImageURL) und zwei Konstruktoren hinzu

    class ImagePost : Post // " : Post" erbt von Post
    {
        public string ImageURL { get; set; }

        public ImagePost(string title, string sentByUsername, string imageURL, bool isPublic) 
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUserName = sentByUsername;
            this.IsPublic = isPublic;
            // Eigenschaft ImageURL welche ein Menber der ImagePost Klasse ist. Jedoch nid von Post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - von {3}", this.ID, this.ImageURL, this.Title, this.SentByUserName);
        }
    }
}
