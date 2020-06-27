using System.Collections.Generic;

namespace TestProject
{
    public class Catalog: IPositionsMenagment
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
        /// Find position by id
        /// </summary>
        /// <param name="id"></param>
        public List<Position> FindPosition(int id)
        {
            var findList = new List<Position>();
            foreach (var item in Positions)
            {
                if (item.Id == id)
                {
                    findList.Add(item);
                }
            }
            return findList;
        }
        /// <summary>
        /// Find position by title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Position> FindPosition(string title)
        {
            var findList = new List<Position>();
            foreach (var item in Positions)
            {
                if (item.Title == title)
                {
                    findList.Add(item);
                }
            }
            return findList;
        }

        public List<Position> FindPositionsByTitle(string title)
        {
            throw new System.NotImplementedException();
        }

        public List<Position> FindPositionsById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
