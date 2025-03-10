﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject2.Pages
{
    public class Language
    {
        public IWebDriver WebDriver { get; }
        public Language(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement LnkLanguage => WebDriver.FindElement(By.CssSelector("a[class='item active']"));
        public IWebElement BtnAdd => WebDriver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment active tooltip-target'] div[class='ui teal button ']"));
        public IWebElement TxtLanguage => WebDriver.FindElement(By.CssSelector("input[placeholder='Add Language']"));
        public IWebElement TxtLevel => WebDriver.FindElement(By.CssSelector("select[name='level']"));
        public IWebElement BtnADD => WebDriver.FindElement(By.CssSelector("input[value='Add']"));

        public void ClickLanguage() => LnkLanguage.Click();
        public void clickAdd() => BtnAdd.Click();
        public void Add1(string language, string level)
        {
            TxtLanguage.SendKeys(language);
            TxtLevel.SendKeys(level);
        }
        public void clickAddButton() => BtnADD.Click();
    }
}