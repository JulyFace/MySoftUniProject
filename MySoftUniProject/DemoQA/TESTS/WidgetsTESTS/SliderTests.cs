using DemoQA.Pages.WidgetsPages.SliderPage;
using NUnit.Framework;

namespace DemoQA.TESTS.WidgetsTESTS
{
    [TestFixture]
    public class SliderTests : BaseTest
    {
        private SliderPage _sliderPage;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sliderPage = new SliderPage(Driver);
            _sliderPage.NavigateTo();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void MaxSliderValue_when_DraggToMaximun() 
        {
            var maxValue = "100";

            Builder.DragAndDrop(_sliderPage.SliderBall, _sliderPage.SliderValueBar).Perform(); 

            Assert.AreEqual(maxValue, _sliderPage.SliderBall.GetAttribute("value"));
           
        }
        [Test]
        public void MinSliderValue_when_DraggToMinimum()
        {
            var minValue = "0";
           
            Builder.DragAndDrop(_sliderPage.SliderBall,_sliderPage.LeftPanel).Perform();

            Assert.AreEqual(minValue, _sliderPage.SliderBall.GetAttribute("value"));

        }

    }

}