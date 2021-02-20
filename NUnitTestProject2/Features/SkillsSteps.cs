using NUnitTestProject2.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NUnitTestProject2.Features
{
    [Binding]
    public class SkillsSteps
    {
        SkillsTab skillstab = null;

        [Given(@"To enter the skill set form")]
        public void GivenToEnterTheSkillSetForm()
        {
            skillstab.ClickSkill();
        }
        
        [Given(@"I click on add New button")]
        public void GivenIClickOnAddNewButton()
        {
            skillstab.AddNew();
        }
        
        [Given(@"I fill the details under the skill tab")]
        public void GivenIFillTheDetailsUnderTheSkillTab(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            skillstab.Add1((string)data.skill, (string)data.level);

        }

        [When(@"you click on add button for skills")]
        public void WhenYouClickOnAddButtonForSkills(Table table)
        {
            skillstab.AddBTN();
        }
    }
}
