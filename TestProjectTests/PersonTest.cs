using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject;

namespace TestProjectTests
{
    [TestClass]
    public class PersonTest
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
