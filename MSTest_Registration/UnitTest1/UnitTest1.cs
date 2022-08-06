using MSTest_Registration;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPasswordRule2()
        {
            //Arrange
            UserRegistration pattern = new UserRegistration();

            bool expected = true;
            string PasswordRule2 = "itriedOk";

            //Act

            bool var = pattern.validateString(PasswordRule2);

            //Assert

            Assert.AreEqual(expected, var);
        }
    }
}