using MSTest_Registration;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPasswordRule4()
        {
            //Arrange
            UserRegistration pattern = new UserRegistration();

            bool expected = true;
            string PasswordRule4 = "iTriedok9$";

            //Act

            bool var = pattern.validateString(PasswordRule4);

            //Assert

            Assert.AreEqual(expected, var);
        }
    }
}