using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowForMe.Pages
{
    internal class BasePage
    {
        protected IWebDriver WebDriver { get; set; }
    }
}
