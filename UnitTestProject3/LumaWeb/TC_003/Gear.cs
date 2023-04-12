using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace LumaProject
{
    public class Gear : Base
    {
        #region LOACTORS
        By gearBTN = By.XPath("//span[contains(text(), 'Gear')]");
        By fitnessequipmentBTN = By.XPath("(//a[contains(text(), 'Fitness Equipment')])[1]");
        By selectfirstBTN = By.XPath("//ol[@class='products list items product-items']/*[1]");
        By addwishlistBTN = By.XPath("//span[contains(text(), 'Add to Wish List')]");
        By accountBTN = By.CssSelector(".nav [href='https://magento.softwaretestingboard.com/customer/account/']");
        By mywishlistBTN = By.CssSelector(".nav [href='https://magento.softwaretestingboard.com/wishlist/']");
        #endregion
        public void gear()
        {
            clickElement(gearBTN);
            clickElement(fitnessequipmentBTN);
            clickElement(selectfirstBTN);
            clickElement(addwishlistBTN);
            clickElement(accountBTN);
            clickElement(mywishlistBTN);
            Thread.Sleep(5000);
            string actualtext = Base.driver.FindElement(By.XPath("//span[contains(text() , 'Sprite Yoga Companion Kit')]")).Text;
            Assert.AreEqual("Sprite Yoga Companion Kit", actualtext);
            
        }

    }
}
