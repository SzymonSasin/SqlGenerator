using SqlGenerator.Tests.Utils;
using TechTalk.SpecFlow;
using Xunit;

namespace SqlGenerator.Tests
{
    [Binding]
    public class AbleToGenerateSelectSteps
    {
        private const string Query = "query";
        private const string SqlText = "sql";

        [Given(@"Select Generator")]
        public void GivenSelectGenerator()
        {
            ScenarioContext.Current[AbleToGenerateSelectSteps.Query] = Sql.Select<TestObject>();
        }

        [Given(@"Table is '(.*)'")]
        public void GivenTableIs(string table)
        {
            var query = ScenarioContext
                .Current
                .Get<IFrom>(AbleToGenerateSelectSteps.Query)
                .Table(table);
            ScenarioContext.Current[AbleToGenerateSelectSteps.Query] = query;
        }

        [Given(@"Table with alias is '(.*)' and alias '(.*)'")]
        public void GivenTableIsWithAlias(string table, string alias)
        {
            var query = ScenarioContext
                .Current
                .Get<IFrom>(AbleToGenerateSelectSteps.Query)
                .Table(table, alias);
            ScenarioContext.Current[AbleToGenerateSelectSteps.Query] = query;
        }

        [Given(@"Where clause is equals between '(.*)' and ""(.*')""")]
        public void GivenWhereClauseIsEquals(string left, string right)
        {
            var query = ScenarioContext
                .Current
                .Get<IWhere>(AbleToGenerateSelectSteps.Query)
                .For(left)
                .IsEqualTo(right);
            ScenarioContext.Current[AbleToGenerateSelectSteps.Query] = query;
        }

        [Given(@"And in bracket Where is equals between '(.*)' and ""(.*)""")]
        public void GivenAndInBracketWhereIsEqualsBetweenAnd(string left, string right)
        {
            var query = ScenarioContext
                  .Current
                  .Get<IWhereJoin>(AbleToGenerateSelectSteps.Query)
                  .And()
                  .Bracket(x => x
                      .For(left)
                      .IsEqualTo(right));

            ScenarioContext.Current[AbleToGenerateSelectSteps.Query] = query;
        }

        [When(@"Request Select for TestObject")]
        public void WhenRequestSelectForTestObject()
        {
            var query = ScenarioContext.Current.Get<IQuery>(AbleToGenerateSelectSteps.Query).ToString();
            ScenarioContext.Current[AbleToGenerateSelectSteps.SqlText] = query;
        }

        [Then(@"I have SQL like '(.*)'")]
        public void ThenIHaveSQLLike(string providedSql)
        {
            var generatedSql = ScenarioContext.Current.Get<string>(AbleToGenerateSelectSteps.SqlText);
            Assert.Equal(providedSql, generatedSql);
        }
    }
}