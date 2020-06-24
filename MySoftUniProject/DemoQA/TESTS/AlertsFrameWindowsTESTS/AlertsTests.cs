

using DemoQA.Pages.AlertsFrameWindowPage.AlertsPage;
using NUnit.Framework;

namespace DemoQA.TESTS.AlertsFrameWindowsTESTS
{
    [TestFixture]
    public class AlertsTests : BaseTest
    {
        private AlertsPage _alertsPage;


        [SetUp]
        public void SetUp()
        {
            Initialize();
           _alertsPage  = new AlertsPage(Driver);

            _alertsPage.NavigateTo();


        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

        }


        [Test]
        public void AssertAlarmMessage_whenFirstRowButtonIsClicked() 
        {
            var expectedText = "You clicked a button";
            
            _alertsPage.ButtonFirstRow.Click();

            
            Assert.AreEqual( expectedText , Driver.SwitchTo().Alert().Text);


        }

        [Test]
        public void AlarmCancel_whenThirdRowButtonIsClickedAndcancelButtonIsSubmited()
        {
            var textAfterDismiss = "You selected Cancel";

            _alertsPage.ButtonThirdRow.Click();
            Driver.SwitchTo().Alert().Dismiss();



            Assert.AreEqual(textAfterDismiss, _alertsPage.AllertMessageButtonThurdRow.Text);


        }







    }
}
