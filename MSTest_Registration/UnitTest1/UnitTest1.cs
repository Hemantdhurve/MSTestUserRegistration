using MSTest_Registration;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPhoneNumber()
        {
            //Arrange
            UserRegistration pattern = new UserRegistration();

            bool expected = true;
            string PhoneNumber = "91 7798051897";

            //Act

            bool var = pattern.validateString(PhoneNumber);

            //Assert

            Assert.AreEqual(expected, var);
        }
    }
}