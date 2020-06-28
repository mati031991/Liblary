using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;

namespace TestProjectTests
{
    [TestClass]
    public class LibraryTests
    {
        private Librarian librarian = new Librarian("Jan", "Testowy", "2020-03-12", 3500);
        private Liblary liblary = new Liblary("Makuszyńskiego 41; 42-200 Czestochowa");
        [TestMethod]
        public void AddLibrarian()
        {

            //Act
            bool result = liblary.AddLibrarian(librarian);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddCatalog()
        {
            //Arrange 
            Catalog catalog = new Catalog("Wojenny");
            //Act
            bool result = liblary.AddCatalog(catalog);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddPosition()
        {
            //Arrange
            string thematicDepartment = "Wojenny";
            Position position = new Book("title1", 45, "publisher12", 2005, 45);
            //Act
            Catalog result = liblary.AddPosition(position, thematicDepartment);
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
