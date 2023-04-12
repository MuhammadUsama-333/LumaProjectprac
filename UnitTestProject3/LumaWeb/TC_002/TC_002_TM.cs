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
    public class TC_002_TM
    {
        
        WhatsNew whatsnew = new WhatsNew();
        [TestMethod]
        public void appliedfilter_TC002()
        {
            
            whatsnew.whatsnew();
            
        }
    }
}
