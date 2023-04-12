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
    public class TC_004_TM
    {
        
        Review review = new Review();
        [TestMethod]
        public void addreview_TC004()
        {
          
            review.review();
            
        }
    }
}
