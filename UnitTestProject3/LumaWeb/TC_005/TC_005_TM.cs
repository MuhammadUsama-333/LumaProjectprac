using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LumaProject
{
    [TestClass]
    public class TC_005_TM
    {
        Quantity quantity = new Quantity();
        [TestMethod]
        public void quant_TC005()
        {
            quantity.quantity();   
        }
    }
}
