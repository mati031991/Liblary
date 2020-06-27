using System.Collections.Generic;

namespace TestProject
{
    public interface IPositionsMenagment
    {
        List<Position> FindPositionsByTitle(string title);

        List<Position> FindPositionsById(int id);

        void DisplayAllPositions();
    }
}
