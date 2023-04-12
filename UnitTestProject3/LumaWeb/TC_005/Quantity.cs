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
    public class Quantity : Base
    {
        #region LOCATORS
        By searchBTN = By.Id("search");
        By searchiconBTN = By.CssSelector("[aria-label='Search']");
        By selectfirstBTN = By.XPath("//ol[@class='products list items product-items']/*[1]");
        By sizeBTN = By.CssSelector("#option-label-size-143-item-178");
        By colorBTN = By.CssSelector("#option-label-color-93-item-57");
        By quantityBTN = By.CssSelector("#qty");
        By addtocartBTN = By.CssSelector("[title='Add to Cart']");
        By cartBTN = By.CssSelector(".minicart-wrapper");
        By cartdetailsBTN = By.CssSelector(".action.viewcart");
        #endregion


        public void quantity() 
        {
            SendKeysMethod(searchBTN, "Pants");
            clickElement(searchiconBTN);
            clickElement(selectfirstBTN);
            Thread.Sleep(4000);
            clickElement(sizeBTN);
            clickElement(colorBTN);
            clickElement(quantityBTN);
            driver.FindElement(quantityBTN).Clear();
            SendKeysMethod(quantityBTN, "500");
            Thread.Sleep(4000);

            clickElement(addtocartBTN);
            Thread.Sleep(4000);

            //clickElement(cartBTN);
            //Thread.Sleep(4000);
            //clickElement(cartdetailsBTN);
            //Thread.Sleep(5000);
            string actualtext = Base.driver.FindElement(By.XPath("(//span[contains(text(), '500')])[1]")).Text;
            Assert.AreEqual("500", actualtext);
            Thread.Sleep(4000);

        }
    }
}
