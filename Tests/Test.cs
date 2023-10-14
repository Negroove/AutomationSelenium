using AutomatizacionPrueba.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Threading;

namespace AutomatizacionPrueba
{
    [TestFixture]
    public class Test : BaseTest
    {
        [Test]
        public void LoginSendbox()
        {
            Login login = new Login(driver);
            login.login("","");
        }
    }
}
