using DemoQA.Pages.WidgetsPages.DatePickerPage;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Drawing;

namespace DemoQA.TESTS.WidgetsTESTS
{
    [TestFixture]
    public class DatePickerTests : BaseTest
    {
        private DatePickerPage _datePickerPage;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _datePickerPage = new DatePickerPage(Driver);
            Driver.Manage().Window.Size = new Size(1080, 800);
            _datePickerPage.NavigateTo();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void InsertADate_withSpaceSeparatedInputs()
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);

            var tom = tomorrow.DayOfWeek.ToString();

            _datePickerPage.DateBar.Click();

            // _datePickerPage.DateBar.SendKeys(Keys.ArrowDown+Keys.Right+Keys.Enter);
            _datePickerPage.DateBar.SendKeys(Keys.ArrowDown + Keys.Right + Keys.Enter);
           
            //var tom = tomorrow.ToString;

            //StringAssert.Contains(_datePickerPage.DateBar.GetAttribute("value"),tomorrow );
            // Assert.AreEqual(,tomorrow );

        }
       
    }

}