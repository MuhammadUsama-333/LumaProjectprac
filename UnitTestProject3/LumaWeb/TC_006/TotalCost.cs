using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LumaProject
{
    public class TotalCost : Base
    {
        #region LOACTORS
        By firstitemBTN = By.CssSelector("[title='Radiant Tee']");
        By firstsizeBTN = By.Id("option-label-size-143-item-166");
        By firstclrBTN = By.Id("option-label-color-93-item-50");
        By firstaddcartBTN = By.CssSelector("[title='Add to Cart']");

        By seconditemBTN = By.CssSelector("[title = 'Breathe-Easy Tank']");
        By secondsizeBTN = By.Id("option-label-size-143-item-166");
        By secondclrBTN = By.Id("option-label-color-93-item-57");
        By secondaddcartBTN = By.CssSelector("[title='Add to Cart']");
       

        #endregion

        public void totalcost()
        {
            clickElement(firstitemBTN);
            Thread.Sleep(3000);
            clickElement(firstsizeBTN);
            clickElement(firstclrBTN);
            clickElement(firstaddcartBTN);
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            clickElement(seconditemBTN);
            Thread.Sleep(3000);
            clickElement(secondsizeBTN);
            clickElement(secondclrBTN);
            clickElement(secondaddcartBTN);
            Thread.Sleep(3000);
            //clickElement(firstclrBTN);
            //clickElement(firstaddcartBTN);
            Thread.Sleep(3000);
            clickElement(secondsizeBTN);
            //clickElement(secondclrBTN);
            //clickElement(secondaddcartBTN);
            Thread.Sleep(3000);
        }
    }
}
