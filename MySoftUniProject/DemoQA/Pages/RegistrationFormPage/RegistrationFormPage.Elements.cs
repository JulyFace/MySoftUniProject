using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.RegistrationFormPage
{
    public partial class RegistrationFormPage : BasePage
    {

        public IWebElement FirstName => Driver.FindElement(By.Id("firstName"));
        public IWebElement LastName => Driver.FindElement(By.Id("lastName"));
        public IWebElement Email => Driver.FindElement(By.Id("userEmail"));
        public IWebElement Gender => Driver.FindElement(By.XPath("//label[contains(text(),'Male')]"));
        public IWebElement Phone => Driver.FindElement(By.XPath("//input[@id='userNumber']"));
        public IWebElement BirthDate => Driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
        public IWebElement HobbiesRadioButton => Driver.FindElement(By.XPath("//label[contains(text(),'Sports')]"));
        public IWebElement Address => Driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
        public IWebElement Submit => Driver.FindElement(By.XPath("//button[@id='submit']"));
        public IWebElement Message => Driver.FindElement(By.XPath("//div[@id='example-modal-sizes-title-lg']"));




    }
}
