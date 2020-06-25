using DemoQA.Pages.RegistrationFormPage;
using DemoQA.UserFactory;
using DemoQA.UserModel;
using NUnit.Framework;


namespace DemoQA.TESTS.RegistrationFormTESTS
{
    [TestFixture]
    public class RegistrationFormTests : BaseTest
    {
        private RegistrationFormPage _registrationFormPage;
        private RegistrationFormModel _user;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _registrationFormPage = new RegistrationFormPage(Driver);
            _registrationFormPage.NavigateTo();
            _user = RegistrationFormFactory.CreateUser();
        }

        [TearDown]
        public void TearDown() 
        {
            Driver.Quit();
        }

        [Test]
        public void HappyPath_SuccsessfulRegistration() 
        {
            var popUpText = "Thanks for submitting the form";
            _registrationFormPage.FillUserCredetnials(_user);


            Assert.AreEqual(popUpText,_registrationFormPage.Message.Text);
        
        
        
        }




    }
}
