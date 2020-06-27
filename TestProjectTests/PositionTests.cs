using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
            Assert.AreEqual(position1, katalog.Positions[0]);
        }
        [TestMethod]
        public void AllPositions()
        {
            //Arrange
            Autor autor1 = new Autor("Sławomir", "Mrożek");
            Autor autor2 = new Autor("Jan", "Testowy");

            Book book1 = new Book("Book1", 1, "Publisher1", 2020, 150);
            book1.AddAutor(autor1);
            Book book2 = new Book("Book2", 2, "Publisher2", 1978, 320);
            book2.AddAutor(autor2);
            Position journal1 = new Journal("Journal1", 1, "Publisher1", 2020, 150);
            Position journal2 = new Journal("Journal2", 2, "Publisher1", 1895, 500);
            List<Position> list = new List<Position>();
            list.Add(book1);
            list.Add(book2);
            list.Add(journal1);
            list.Add(journal2);

            Katalog katalog = new Katalog();

            //Act
            katalog.AddPosition(book1);
            katalog.AddPosition(book2);
            katalog.AddPosition(journal1);
            katalog.AddPosition(journal2);
            var result = katalog.FindPosition("Book2");

            //Assert
            CollectionAssert.AreEqual(katalog.Positions, list);
            Assert.IsNotNull(result);
        }
    }
}
