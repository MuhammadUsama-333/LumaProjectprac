using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProject
{
    [TestClass]
    public class TC_006_TM
    {
        
        TotalCost totalCost = new TotalCost();
        [TestMethod]
        public void totalcost()
        {
            totalCost.totalcost();
        }
    }
}
