using DemoQA.Pages.WidgetsPages.DatePickerPage;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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
            _datePickerPage.DateBar.Click();
           // _datePickerPage.DateBar.SendKeys(Keys.ArrowDown+Keys.Right+Keys.Enter);
            _datePickerPage.DateBar.SendKeys(Keys.ArrowDown+Keys.Right+Keys.Enter);


            Assert.AreEqual(_datePickerPage.DateBar.GetAttribute("value"),tomorrow );
        
        
        
        
        
        
        
        
        
        
        }
    }

}