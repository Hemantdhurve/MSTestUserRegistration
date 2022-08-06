using MSTest_Registration;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            UserRegistration pattern = new UserRegistration();

            bool expected = true;
            string FirstName = "Hemant";

            //Act

            bool var = pattern.validateString(FirstName);

            //Assert

            Assert.AreEqual(expected, var);
        }
    }
}