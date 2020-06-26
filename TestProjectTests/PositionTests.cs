using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;

namespace TestProjectTests
{
    [TestClass]
    public class PositionTests
    {
        [TestMethod]
        public void AddPosition()
        {
            //Arrange
            Position position1 = new Book("Book1", 1, "Publisher1", 2020, 150);
            Katalog katalog = new Katalog();

            //Act
            katalog.AddPosition(position1);
            //Assert
            Assert.AreEqual(position1,katalog.Positions[0]);
        }
    }
}
