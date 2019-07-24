using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Treinaweb.CalculadoraT.XUnit
{
    public class ChromeTests : IDisposable
    {
        private IWebDriver _driver;

        public ChromeTests()
        {
            _driver = new ChromeDriver();           
        }

        public void Dispose()
        {
            if (_driver != null)
                _driver.Close();

        }

        [Fact]
        public void TestSomarNumeros()
        {
            _driver.Navigate().GoToUrl("");
            IWebElement txtPrimeiroNum = _driver.FindElement(By.Name("txtPrimeiroNum"));
            txtPrimeiroNum.SendKeys("2");

            IWebElement txtSegundoNum = _driver.FindElement(By.Name("txtSegundoNum"));
            txtSegundoNum.SendKeys("2");

            List<IWebElement> options = _driver.FindElements(By.Name("option")).ToList();
            foreach(IWebElement element in options)
            {
                if (element.Text.Equals("Adição"))
                {
                    element.Click();
                    break;
                }
            }

            IWebElement btnCalcular = _driver.FindElement(By.Name("btnCalcular"));
            btnCalcular.Click();
            Assert.Equal("4", _driver.FindElement(By.Name("txtResultado")).GetAttribute("value").ToString());
        }


    }
}
