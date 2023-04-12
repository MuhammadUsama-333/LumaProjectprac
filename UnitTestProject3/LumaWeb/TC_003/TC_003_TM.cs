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
    [TestClass]
    public class TC_003_TM
    {
        
        Gear gear = new Gear();
        [TestMethod]
        public void wishlist_TC003()
        {
            
            gear.gear();
        
        }
    }
}
