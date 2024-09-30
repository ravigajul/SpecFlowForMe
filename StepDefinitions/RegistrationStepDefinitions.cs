using System.Net.Mail;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowForMe.StepDefinitions
{
    [Binding]
    public sealed class RegistrationStepDefinitions
    {
        private IWebDriver driver;
        [Given(@"the user navigates to the user registration page")]
        public void GivenTheUserNavigatesToTheUserRegistrationPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demo.automationtesting.in/Register.html";
        }

        [When(@"the user fills the forms and submits")]
        public void WhenTheUserFillsTheFormsAndSubmits()
        {
            driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys("Ravi");
            driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys("Gajul");
            driver.FindElement(By.XPath("//textarea[@ng-model='Adress']")).SendKeys("17030 N 49th Street");
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("Ravi.Gajul@test.com");
            driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys("9052046524");
            driver.FindElement(By.XPath("//input[@type='radio']")).Click();
            driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//div[@id='msdd']")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'English')]")).Click();
            IWebElement skills = driver.FindElement(By.XPath("//select[@id='Skills']"));
            SelectElement selectElement = new SelectElement(skills);
            selectElement.SelectByIndex(1);

            SelectElement countries = new SelectElement(driver.FindElement(By.XPath("//select[@id='countries']")));
            countries.SelectByIndex(1);


        }

        [Then(@"the success message is displayed")]
        public void ThenTheSuccessMessageIsDisplayed()
        {
            throw new PendingStepException();
        }
    }
}
