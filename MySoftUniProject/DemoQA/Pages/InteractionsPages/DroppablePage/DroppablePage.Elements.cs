﻿
using DemoQA.Pages;
using OpenQA.Selenium;


namespace DemoQA.Pages.InteractionsPages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {


        //Simple
        public IWebElement DragMeBox => Driver.FindElement(By.Id("draggable"));

        public IWebElement DropMeBox => Driver.FindElement(By.Id("droppable"));


        // Accept
        public IWebElement AcceptDroppable => Driver.FindElement(By.XPath("//*[@id='droppableExample-tab-accept']"));

        public IWebElement NotAcceptableBox => Driver.FindElement(By.XPath("//*[@id='notAcceptable']"));

        public IWebElement TargetBox => Driver.FindElement(By.XPath("//div[@id='acceptDropContainer']//div[@id='droppable']"));



        // Revert 
        public IWebElement RevertDroppable => Driver.FindElement(By.XPath("//*[@id='droppableExample-tab-revertable']"));

        public IWebElement NotRevertBox => Driver.FindElement(By.XPath("//*[@id='notRevertable']"));

        public IWebElement TargetBoxREVERT => Driver.FindElement(By.XPath("//div[@id='revertableDropContainer']//div[@id='droppable']"));





    }
}
