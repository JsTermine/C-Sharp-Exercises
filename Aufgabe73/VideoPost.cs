using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aufgabe73
{
    class VideoPost : Post
    {
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public string Description{ get; set; }

        public VideoPost(string videoURL, int length, string description)
        {
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public VideoPost() { }

        // Default
        public VideoPost(string title, string sentByUserName, string videoURL, bool isPublic, int length) 
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUserName = sentByUserName;
            this.IsPublic = isPublic;


            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString() 
        {
            return String.Format("{0} - {1} - {2} - {3} - von {4}", this.ID, this.VideoURL, this.Length, this.Title, this.SentByUserName);
        }

    }
}
