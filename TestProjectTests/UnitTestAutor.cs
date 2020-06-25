using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestProject;

namespace TestProjectTests
{
    [TestClass]
    public class UnitTestAutor
    {
        [TestMethod]
        public void AddNewAutorToListTest()
        {
            //Arrange
            Autor Autor = new Autor("Juliusz", "S³owacki");
            List<Autor> list1 = new List<Autor>();
            list1.Add(Autor);
            Book Book = new Book();
            //Act
            var actual = Book.AddAutor(Autor);
            //Assert
            Assert.AreEqual(list1[0], actual[0]);
        }
    }
}
