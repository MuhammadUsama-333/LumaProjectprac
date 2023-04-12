using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LumaProject
{
    public class LoginPage : Base
    {

        #region LOCATORS
        By signinBTN = By.XPath("//a[contains(text(), \"Sign In\")]");
        By mail = By.Id("email");
        By pass = By.Id("pass");
        By signin = By.XPath("(//span[contains(text(), 'Sign In')])[1]");
        #endregion


        public void Login(string email, string password)
        {
           
            clickElement(signinBTN);
            SendKeysMethod(mail, email);
            SendKeysMethod(pass, password);
            clickElement(signin);
            Thread.Sleep(3000);
            string actualtext = Base.driver.FindElement(By.XPath("(//span[@class='logged-in'])[1]")).Text;
            Assert.AreEqual("Welcome, Muhammad Usama!", actualtext);
            
        }
    }
}
