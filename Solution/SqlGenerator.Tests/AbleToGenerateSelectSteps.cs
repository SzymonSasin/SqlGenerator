using SqlGenerator.Tests.Utils;
using TechTalk.SpecFlow;
using Xunit;

namespace SqlGenerator.Tests
{
    [Binding]
    public class AbleToGenerateSelectSteps
    {
        [Given(@"Select Generator")]
        public void GivenSelectGenerator()
        {
            ScenarioContext.Current.Add("Select", Sql.Select<TestObject>());
        }

        [When(@"Request Select for TestObject")]
        public void WhenRequestSelectForTestObject()
        {
            var select = ScenarioContext.Current.Get<ISelect>("Select");

            ScenarioContext.Current.Add("SQL", select.ToString());
        }

        [Then(@"I have SQL like '(.*)'")]
        public void ThenIHaveSQLLike(string providedSql)
        {
            var generatedSql = ScenarioContext.Current.Get<string>("SQL");
            Assert.Equal(providedSql, generatedSql);
        }
    }
}