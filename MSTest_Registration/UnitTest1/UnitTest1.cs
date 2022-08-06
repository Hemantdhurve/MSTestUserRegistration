using MSTest_Registration;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPasswordRule3()
        {
            //Arrange
            UserRegistration pattern = new UserRegistration();

            bool expected = true;
            string PasswordRule3 = "iTriedok9";

            //Act

            bool var = pattern.validateString(PasswordRule3);

            //Assert

            Assert.AreEqual(expected, var);
        }
    }
}