using KPMG.HealthRecordAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V124.Emulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordAutomation.Test
{

    public class LoginUITest:AutomationWraper 

    {
        

        [Test]
        public void TitleTest()
        {  
            string actualTitle = driver.Title;
            //Assert.Equals(actualTitle, "OpenEMR Login"); 
            Assert.That(actualTitle,Is.EqualTo("OpenEMR Login"));
        }

        [Test]
       public void AppDescriptionTest()
        {
            string actualDesc = driver.FindElement(By.XPath("//p[contains(text(),'most')]")).Text;
            Assert.That(actualDesc, Is.EqualTo("The most popular open-source Electronic Health Record and Medical Practice Management solution."));
        }
    }
}
