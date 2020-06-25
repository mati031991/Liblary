using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class Book : Position
    {
        private int _page_numbers;
        private List<Autor> autors;

        public Book()
        {
            autors = new List<Autor>();
        }
        public Book(string title, int id, string publisher, int publisherYear, int page_numbers)
        {
            this.Title = title;
            this.Id = id;
            this.Publisher = publisher;
            this.PublisherYear = publisherYear;
            this._page_numbers = page_numbers;
        }

        public List<Autor> AddAutor(Autor autor)
        {
            if (autor!=null)
            {
                autors.Add(autor);
            }
            return autors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(
                "Tytuł: {0}, Id: {1}, Wydawnictwo: {2}, Rok wydania: {3}, Liczba stron: {4} ", this.Title, this.Id, this.Publisher, this.PublisherYear, this._page_numbers
                );
        }

    }
}
