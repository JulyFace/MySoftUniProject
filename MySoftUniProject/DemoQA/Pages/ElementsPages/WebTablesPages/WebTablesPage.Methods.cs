

using DemoQA.UserModel;
using OpenQA.Selenium;

namespace DemoQA.Pages.ElementsPages
{
    public partial class WebTablesPage : BasePage
    {
        public WebTablesPage(IWebDriver driver)
           : base(driver)
        {

        }

        public override string PageUrl => "https://demoqa.com/webtables";

        public void FillUserData(WebTablesModel user) 
        {
            FirstName.SendKeys(user.FirstName);
            LasttName.SendKeys(user.LastName);
            Email.SendKeys(user.Email);
            Age.SendKeys(user.Age);
            Salary.SendKeys(user.Salary);
            Department.SendKeys(user.Department);
        
        }



    }
}
