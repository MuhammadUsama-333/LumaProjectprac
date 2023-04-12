using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LumaProject
{
    public class Review : Base
    {
        #region LOCATORS
        By searchBTN = By.Id("search");
        By searchiconBTN = By.CssSelector("[aria-label='Search']");
        By selectfirstBTN = By.XPath("//ol[@class='products list items product-items']/*[1]");
        By reviewsBTN = By.CssSelector("a[href='https://magento.softwaretestingboard.com/selene-yoga-hoodie.html#review-form']");
        By ratingBTN = By.ClassName("rating-1");
        By summaryBTN = By.XPath("//input[@id='summary_field']");
        By reviewBTN = By.XPath("//textarea[@id='review_field']");
        By submitBTN = By.XPath("//span[contains(text(), 'Submit Review')]");
        #endregion

        public void review()
        {
            SendKeysMethod(searchBTN, "Selene Yoga Hoodie");
            clickElement(searchiconBTN);
            clickElement(selectfirstBTN);
            Thread.Sleep(4000);
            clickElement(reviewsBTN);
            Thread.Sleep(4000);
            var element = Base.driver.FindElement(ratingBTN);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(8000);
            clickElement(ratingBTN);
            Thread.Sleep(4000);
            SendKeysMethod(summaryBTN, "gooooood");
            SendKeysMethod(reviewBTN, "I like it");
            clickElement(submitBTN);

        }

    }
}
