using TechTalk.SpecFlow;

namespace SqlGenerator.Tests
{
    [Binding]
    public class AbleToGenerateSelectSteps
    {
        [Given(@"Select Generator")]
        public void GivenSelectGenerator()
        {
            //ScenarioContext.Current.Add("Select", new Select());
        }

        [When(@"Request Select for TestObject")]
        public void WhenRequestSelectForTestObject()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I have SQL like '(.*)'")]
        public void ThenIHaveSQLLike(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}