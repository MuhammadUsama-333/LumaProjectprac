using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LumaProject
{
    public class WhatsNew : Base
    {
        #region LOCATORS
        By whatnewBTN = By.XPath("//span[contains(text(), \"What's New\")]");
        By jacketsBTN = By.CssSelector(".item [href='https://magento.softwaretestingboard.com/women/tops-women/jackets-women.html']");
        By sizeBTN = By.XPath("//div[contains(text(), \"Size\")]\r\n");
        By xlBTN = By.CssSelector("[option-id='170'][tabindex='-1']");
        By priceBTN = By.XPath("//div[contains(text(),'Price')]");
        By priceselectBTN = By.CssSelector(".filter-options-content .item [href='https://magento.softwaretestingboard.com/women/tops-women/jackets-women.html?price=60-70&size=170']");
        By colorBTN = By.XPath("//div[contains(text(),'Color')]");
        By colorselectBTN = By.CssSelector(".swatch-option[option-id='49'][tabindex='-1']");
        By gridBTN = By.XPath("//ol[@class='products list items product-items']/*[1]");
        #endregion

        public void whatsnew()
        {
            clickElement(whatnewBTN);
            clickElement(jacketsBTN);
            clickElement(sizeBTN);
            clickElement(xlBTN);
            clickElement(priceBTN);
            clickElement(priceselectBTN);
            clickElement(colorBTN);
            clickElement(colorselectBTN);
            clickElement(gridBTN);
            Thread.Sleep(3000);
            string actualtext = Base.driver.FindElement(By.Id("product-price-1364")).Text;
            Assert.AreEqual("$69.00", actualtext);
            Thread.Sleep(3000);
        }
    }
}
