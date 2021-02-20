using FluentValidation.Resources;
using Nest;
using NUnitTestProject2.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Language = NUnitTestProject2.Pages.Language;

namespace NUnitTestProject2.Features
{
    [Binding]
    public class LanguageSteps
    {
        Language language = null;

        [Given(@"To enter the skill set tab")]
        public void GivenToEnterTheLanguagesSetTab()
        {
            language.ClickLanguage();
        }
        
        [Given(@"when you enter add feature for language")]
        public void GivenWhenYouEnterAddFeatureForLanguage()
        {
            language.clickAdd();
        }
        
        [When(@"you choose the option and click on add")]
        public void WhenYouChooseTheOptionAndClickOnAdd(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            language.Add1((string)data.language, (string)data.level);  
        }
        
        [Then(@"details will be saved")]
        public void ThenDetailsWillBeSaved()
        {
             language.clickAddButton();
        }
    }
}
