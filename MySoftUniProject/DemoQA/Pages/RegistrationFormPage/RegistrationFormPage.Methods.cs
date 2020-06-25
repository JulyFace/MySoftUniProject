using DemoQA.Extentions;
using DemoQA.UserModel;
using OpenQA.Selenium;


namespace DemoQA.Pages.RegistrationFormPage
{
    public partial class RegistrationFormPage : BasePage
    {
        public RegistrationFormPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string PageUrl => "http://www.demoqa.com/automation-practice-form";

        public void FillUserCredetnials(RegistrationFormModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Email.SendKeys(user.Email);
            Gender.Click();
            Phone.SendKeys(user.Phone);
            Driver.ScrollTo(HobbiesRadioButton);
            HobbiesRadioButton.Click();
            Address.SendKeys(user.Address);
            
            Submit.Click();



        }




    }
}
