using DemoQA.Pages.ElementsPages;
using DemoQA.UserFactory;
using DemoQA.UserModel;
using NUnit.Framework;

namespace DemoQA.TESTS.ElementsTESTS
{
    [TestFixture]
    public class WebTablesTests : BaseTest
    {
        private WebTablesModel _user;
        private WebTablesPage _webTablesPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _webTablesPage = new WebTablesPage(Driver);
            _webTablesPage.NavigateTo();
            _user = WebTablesFactory.UserData();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void WebTablesTest()
        {

            _webTablesPage.AddButton.Click();
            _webTablesPage.FillUserData(_user);
            _webTablesPage.SubmitButton.Click();

            Assert.AreEqual(_user.FirstName, _webTablesPage.ActualFirstName.Text) ;
            Assert.AreEqual(_user.LastName, _webTablesPage.ActualLasttName.Text) ;
            Assert.AreEqual(_user.Age, _webTablesPage.ActualAge.Text) ;
            Assert.AreEqual(_user.Email, _webTablesPage.ActualEmail.Text) ;
            Assert.AreEqual(_user.Salary, _webTablesPage.ActualSalary.Text) ;
            Assert.AreEqual(_user.Department, _webTablesPage.ActualDepartment.Text) ;
            

        }





    }
}
