using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public abstract class Position
    {
        public string Title { get; set; }

        public int Id { get; set; }

        public string Publisher { get; set; }

        public int PublisherYear { get; set; }

        public Position()
        {

        }
        public Position(string title, int id, string publisher, int publisherYear)
        {
            this.Title = title;
            this.Id = id;
            this.Publisher = publisher;
            this.PublisherYear = PublisherYear;
        }
        public abstract void DisplayInfo();
    }
}
