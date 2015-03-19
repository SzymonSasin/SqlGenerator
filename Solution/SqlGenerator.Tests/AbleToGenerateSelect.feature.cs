﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable

namespace SqlGenerator.Tests
{
    using TechTalk.SpecFlow;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AbleToGenerateSelectFeature : Xunit.IClassFixture<AbleToGenerateSelectFeature.FixtureData>, System.IDisposable
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "AbleToGenerateSelect.feature"
#line hidden

        public AbleToGenerateSelectFeature()
        {
            this.TestInitialize();
        }

        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AbleToGenerateSelect", "In order generate select statement\r\nAs a SQL newbie\r\nI want to use object to give" +
                    " me my SQL", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void TestInitialize()
        {
        }

        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        public virtual void SetFixture(AbleToGenerateSelectFeature.FixtureData fixtureData)
        {
        }

        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AbleToGenerateSelect")]
        [Xunit.TraitAttribute("Description", "Simple Select From object")]
        public virtual void SimpleSelectFromObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simple Select From object", new string[] {
                        "select"});
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 8
            testRunner.Given("Select Generator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
            testRunner.When("Request Select for TestObject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
            testRunner.Then("I have SQL like \'SELECT t.Id, t.Name, t.OrderId FROM TestObject t\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AbleToGenerateSelect")]
        [Xunit.TraitAttribute("Description", "Simple Select From object with alias")]
        public virtual void SimpleSelectFromObjectWithAlias()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simple Select From object with alias", new string[] {
                        "select"});
#line 13
            this.ScenarioSetup(scenarioInfo);
#line 14
            testRunner.Given("Select Generator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
            testRunner.And("Alias is \'to\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
            testRunner.When("Request Select for TestObject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
            testRunner.Then("I have SQL like \'SELECT to.Id, to.Name, to.OrderId FROM TestObject to\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "AbleToGenerateSelect")]
        [Xunit.TraitAttribute("Description", "Simple where")]
        public virtual void SimpleWhere()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simple where", ((string[])(null)));
#line 19
            this.ScenarioSetup(scenarioInfo);
#line 20
            testRunner.Given("Select Generator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
            testRunner.And("where clause is \'Name = \'Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
            testRunner.When("Request Select for TestObject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
            testRunner.Then("I have SQL like \'SELECT t.Id, t.Name, t.Orderid FROM TestObject t WHERE t.Name = " +
                               "\'Test\'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            public FixtureData()
            {
                AbleToGenerateSelectFeature.FeatureSetup();
            }

            void System.IDisposable.Dispose()
            {
                AbleToGenerateSelectFeature.FeatureTearDown();
            }
        }
    }
}

#pragma warning restore