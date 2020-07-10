using OpenQA.Selenium;


namespace DemoQA.Pages.ElementsPages
{
    public partial class WebTablesPage : BasePage
    {
       

        public IWebElement AddButton => Driver.FindElement(By.XPath("//button[contains(text(),'Add')]"));
        public IWebElement FirstName => Driver.FindElement(By.XPath("//input[@id='firstName']"));
        public IWebElement LasttName => Driver.FindElement(By.XPath("//input[@id='lastName']"));
        public IWebElement Email  => Driver.FindElement(By.XPath("//input[@id='userEmail']"));
        public IWebElement Age  => Driver.FindElement(By.XPath("//input[@id='age']"));
        public IWebElement Salary  => Driver.FindElement(By.XPath("//input[@id='salary']"));
        public IWebElement Department  => Driver.FindElement(By.XPath("//input[@id='department']"));
        public IWebElement SubmitButton  => Driver.FindElement(By.XPath("//button[@id='submit']"));


        public IWebElement ActualFirstName => Driver.FindElement(By.XPath("//div[@class='rt-tbody']//div[contains(text(),'Juliano')]"));
        public IWebElement ActualLasttName => Driver.FindElement(By.XPath("//div[@class='rt-tbody']//div[contains(text(),'Borichelo')]"));
        public IWebElement ActualEmail => Driver.FindElement(By.XPath("//div[@class='rt-tbody']//div[contains(text(),'abv@gmail.com')]"));
        public IWebElement ActualAge => Driver.FindElement(By.XPath("//div[@class='rt-tbody']//div[contains(text(),'33')]"));
        public IWebElement ActualSalary => Driver.FindElement(By.XPath("//div[@class='rt-tbody']//div[contains(text(),'20000')]"));
        public IWebElement ActualDepartment => Driver.FindElement(By.XPath("//div[@class='rt-tbody']//div[contains(text(),'IT')]"));


    }
}


