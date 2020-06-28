using System.Collections.Generic;

namespace TestProject
{
    public class Catalog : IPositionsMenagment
    {
        private string _thematicDepartmant;
        public List<Position> Positions;
        public Catalog()
        {
            Positions = new List<Position>();
        }
        public Catalog(string thematicDepartmant)
        {
            this._thematicDepartmant = thematicDepartmant;
            Positions = new List<Position>();
        }
        public void AddPosition(Position position)
        {
            Positions.Add(position);
        }
        public void DisplayAllPositions()
        {
            foreach (var item in Positions)
            {
                item.DisplayInfo();
            }
        }
        /// <summary>
        /// Find position by title
        /// </summary>
        /// <param name="title"></param>
       
        public List<Position> FindPositionsByTitle(string title)
        {
            List<Position> position = new List<Position>();
            foreach (var item in Positions)
            {
                if (item.Title == title)
                {
                    position.Add(item);
                }
            }
            return position;
        }

        /// <summary>
        /// Find position by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Position> FindPositionsById(int id)
        {
            List<Position> position = new List<Position>();
            foreach (var item in Positions)
            {
                if (item.Id == id)
                {
                    position.Add(item);
                }
            }
            return position;
        }
    }
}
