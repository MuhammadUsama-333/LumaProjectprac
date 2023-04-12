using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace LumaProject
{
    public class Base
    {
        public static IWebDriver driver;
        public static IWebDriver SeleniumInit()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            driver = chromeDriver;
            driver.Url = "https://magento.softwaretestingboard.com/";
            driver.Manage().Window.Maximize();
            return driver;


        }
        #region SendKeys
        public void SendKeysMethod(By locator, string text)
        {
            if (driver.FindElement(locator).GetAttribute("value") != " ")
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
            else
            {
                driver.FindElement(locator).SendKeys(text);
            }
        }
        #endregion
        #region Click
        public void clickElement(By locator)
        {

            driver.FindElement(locator).Click();

        }
        #endregion



        


            //}
            //#endregion

            //#region DropDown
            //public void dropdown(By loc, string type, string value)
            //{
            //    IWebElement element = driver.FindElement(loc);
            //    SelectElement drpdwn = new SelectElement(element);
            //    if (type == "value")
            //    {
            //        drpdwn.SelectByValue(value);
            //        element.Click();
            //    }

            //    else if (type == "text")
            //    {
            //        drpdwn.SelectByText(value);
            //        element.Click();
            //    }

            //    else if (type == "index")
            //    {
            //        drpdwn.SelectByIndex(Convert.ToInt32(value));
            //        element.Click();
            //    }
            //}
            //#endregion
        }
}
