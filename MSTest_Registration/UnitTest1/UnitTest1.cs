using MSTest_Registration;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPasswordRule1()
        {
            //Arrange
            UserRegistration pattern = new UserRegistration();

            bool expected = true;
            string PasswordRule1 = "itriedok";

            //Act

            bool var = pattern.validateString(PasswordRule1);

            //Assert

            Assert.AreEqual(expected, var);
        }
    }
}