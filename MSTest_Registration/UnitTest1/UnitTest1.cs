using MSTest_Registration;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLastName()
        {
            //Arrange
            UserRegistration pattern = new UserRegistration();

            bool expected = true;
            string LastName = "Hemant";

            //Act

            bool var = pattern.validateString(LastName);

            //Assert

            Assert.AreEqual(expected, var);
        }
    }
}