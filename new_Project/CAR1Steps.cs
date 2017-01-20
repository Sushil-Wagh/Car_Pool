using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace new_Project
{
    [Binding]
    public class CAR1Steps
    {
        Calculator cals = new Calculator();
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            cals.Input1 = cals.Input1  + p0;

            //Assert.AreEqual(50, p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
          
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(120, cals.Input1);
        }
    }
}
