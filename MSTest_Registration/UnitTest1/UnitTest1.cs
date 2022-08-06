using MSTest_Registration;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSampleEmails()
        {
            //Arrange
            UserRegistration pattern = new UserRegistration();

            bool expected = true;
            string SampleEmails = "abc+100@gmail.com";

            //Act

            bool var = pattern.validateString(SampleEmails);

            //Assert

            Assert.AreEqual(expected, var);
        }
    }
}