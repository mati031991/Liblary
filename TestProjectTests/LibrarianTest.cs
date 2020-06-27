using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;

namespace TestProjectTests
{
    [Ignore]
    [TestClass]
    public class LibrarianTest
    {
        [TestMethod]
        public void AddLibrarian()
        {
            //Arrange
            Librarian librarian = new Librarian("Jan","Testowy","2020-03-12",3500);

            //Act

            //Assert

        }
    }
}
