using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class Journal : Position
    {
        private int _number;

        public Journal()
        {

        }
        public Journal(string title, int id, string publisher, int publisherYear, int number)
        {
            this.Title = title;
            this.Id = id;
            this.Publisher = publisher;
            this.PublisherYear = publisherYear;
            this._number = number;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(
                 "Tytuł: {0}, Id: {1}, Wydawnictwo: {2}, Rok wydania: {3}, Numer: {4} ", this.Title, this.Id, this.Publisher, this.PublisherYear, this._number
                 );
        }
    }
}
