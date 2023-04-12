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
    public class TC_001_TM
    {
        LoginPage loginpage = new LoginPage();
        [TestMethod]
        public void login_TC_001()
        {
            Base.SeleniumInit();
            loginpage.Login("jjookkeerr393@gmail.com", "1640609@Joker");
            Thread.Sleep(3000);
            
        }
    }
}
