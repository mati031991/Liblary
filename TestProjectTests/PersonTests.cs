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
            //Arrange and Act
            Person person1 = new Person("Anna", "Maria");

            //Assert
            Assert.AreEqual("Anna", person1.Foranme);
            Assert.AreEqual("Maria", person1.Name);
        }
    }
}
