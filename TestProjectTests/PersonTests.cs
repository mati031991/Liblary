using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;

namespace TestProjectTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetPerson()
        {
            //Arrange
            Person person1 = new Person("Anna", "Maria");
            //Act

            //Assert
            Assert.AreEqual("Anna", person1.Foranme);
            Assert.AreEqual("Maria", person1.Name);
        }
    }
}
