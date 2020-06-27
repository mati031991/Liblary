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
            throw new NotImplementedException();
        }

        public List<Position> FindPositionsById(int id)
        {
            throw new NotImplementedException();
        }

        public void DisplayAllPositions()
        {
            throw new NotImplementedException();
        }
    }
}
