using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PeoplesRepo.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Test_CreatePersonShouldSetProperties()
        {
            // arrange

            // act
            // assert

            var firstname = "Test";
            var lastname = "Test1";
            var age = 21;

            // act
            var person = new Person(firstname, lastname , age);

            // assert

            Assert.AreEqual(firstname, person.Firstname);
            Assert.AreEqual(lastname, person.Lastname);
            Assert.AreEqual(age, person.Age);
            

        }
    }
}
