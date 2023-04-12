using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;


namespace LumaProject
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyStart(TestContext TestContext)
        {
            LoginPage log = new LoginPage();
            Base.SeleniumInit();

            log.Login("jjookkeerr393@gmail.com", "1640609@Joker");

        }
        [AssemblyCleanup]
        public static void AssemblyEnd()
        {
            Base.driver.Close();
        }
  
        [TestMethod]
        public void LoginWithValid_TC001()
        {
            TC_002_TM test2= new TC_002_TM();
            test2.appliedfilter_TC002();
            TC_003_TM test3= new TC_003_TM();
            test3.wishlist_TC003();
            TC_004_TM test4 = new TC_004_TM();
            test4.addreview_TC004();
            TC_005_TM test5 = new TC_005_TM();
            test5.quant_TC005();
            TC_006_TM test6 = new TC_006_TM();
            test6.totalcost();
        }
            

        
    }
    
}
