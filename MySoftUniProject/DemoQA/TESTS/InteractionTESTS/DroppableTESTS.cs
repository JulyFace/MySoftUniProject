﻿using DemoQA.Extentions;
using DemoQA.Pages.InteractionsPages.DroppablePage;
using NUnit.Framework;


namespace DemoQA.TESTS.InteractionTESTS
{

    [TestFixture]
    public class DroppableTESTS : BaseTest
    {

        
        private DroppablePage _droppablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();
        }

        [Test]
        public void DropElementChangeColorOfTarget_When_DragAndDropDragMe_SIMPLE()
        {
            var colorBefore = _droppablePage.DropMeBox.GetCssColor();

            Builder.DragAndDrop(_droppablePage.DragMeBox, _droppablePage.DropMeBox).Perform();

            Assert.AreNotEqual(colorBefore, _droppablePage.DropMeBox.GetCssColor());
        }

        [Test]
        public void DontAcceptDraggableBox_whenMovedToTargetBox_ACCEPT()
        {
            var targetBoxColorBofore = _droppablePage.TargetBox.GetCssColor();
            var sourceBoxLocationBefore = _droppablePage.NotAcceptableBox.Location;
            var _sourceBox = _droppablePage.NotAcceptableBox;
            
            
            _droppablePage.AcceptDroppable.Click();
            Builder.ClickAndHold(_sourceBox).MoveToElement(_droppablePage.TargetBox).Release(_sourceBox)
                .Perform();


            Assert.IsTrue(sourceBoxLocationBefore != _sourceBox.Location);
            Assert.AreEqual(targetBoxColorBofore, _droppablePage.TargetBox.GetCssColor());

           
        }

        [Test]
        public void RevertBox_when_WillRevertBoxMovedToTargetBox()
        {

            var notRevertBoxLocationBefore = _droppablePage.NotRevertBox.Location;

            _droppablePage.RevertDroppable.Click();
            Builder.ClickAndHold(_droppablePage.NotRevertBox).MoveToElement(_droppablePage.TargetBoxREVERT).Release().Perform();


            Assert.AreNotEqual(notRevertBoxLocationBefore, _droppablePage.NotRevertBox.Location);

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }


    }
}