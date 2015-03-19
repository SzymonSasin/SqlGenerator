using SqlGenerator.Tests.Utils;
using TechTalk.SpecFlow;
using Xunit;

namespace SqlGenerator.Tests
{
    [Binding]
    public class AbleToGenerateSelectSteps
    {
        private ISelect Select
        {
            get
            {
                return ScenarioContext.Current.Get<ISelect>("Select");
            }
        }

        [Given(@"Select Generator")]
        public void GivenSelectGenerator()
        {
            ScenarioContext.Current.Add("Select", Sql.Select<TestObject>());
        }

        [Given(@"Alias is '(.*)'")]
        public void GivenAliasIs(string alias)
        {
            this.Select.Alias(alias);
        }

        [Given(@"where clause is '(.*)'")]
        public void GivenWhereClauseIsTest(string whereClase)
        {
            this.Select.Where(whereClase);
        }

        [When(@"Request Select for TestObject")]
        public void WhenRequestSelectForTestObject()
        {
            ScenarioContext.Current.Add("SQL", Select.ToString());
        }

        [Then(@"I have SQL like '(.*)'")]
        public void ThenIHaveSQLLike(string providedSql)
        {
            var generatedSql = ScenarioContext.Current.Get<string>("SQL");
            Assert.Equal(providedSql, generatedSql);
        }
    }
}