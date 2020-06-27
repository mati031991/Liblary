using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class Liblary : IPositionsMenagment
    {
        private string _addres;
        private List<Librarian> librarians;
        private List<Catalog> catalogs;
        private List<Position> positions;

        public Liblary()
        {
            librarians = new List<Librarian>();
            catalogs = new List<Catalog>();
        }
        public Liblary(string addres)
        {
            this._addres = addres;
            librarians = new List<Librarian>();
            catalogs = new List<Catalog>();
        }
        public bool Addlibrarian(Librarian librarian)
        {
            if (librarian != null)
            {
                librarians.Add(librarian);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddCatalog(Catalog catalog)
        {
            if (catalog != null)
            {
                catalogs.Add(catalog);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddPosition(Position p, string thematicDepartment)
        {
            if (p != null)
            {
                positions.Add(p);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Position> FindPositionsByTitle(string title)
        {
            List<Position> positions = new List<Position>();
            foreach (var item in this.positions)
            {
                if (item.Title == title)
                {
                    positions.Add(item);
                }
            }
            return positions;
        }

        public List<Position> FindPositionsById(int id)
        {
            List<Position> positions = new List<Position>();
            foreach (var item in this.positions)
            {
                if (item.Id == id)
                {
                    positions.Add(item);
                }
            }
            return positions;
        }

        public void DisplayAllPositions()
        {
            Console.WriteLine(
                "Costam"
                );
        }
    }
}
