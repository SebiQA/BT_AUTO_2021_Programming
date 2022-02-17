using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.Tests
{
    class AuthTest : BaseTest
    {

        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()


        {
            string path = "TestData\\credentials.csv";
            using (var reader = new StreamReader(path))
            {
                var index = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (index > 0)
                    {
                        yield return new TestCaseData(values[0], values[1]);
                    }
                    index++;
                }
            }
        }

        [Test, TestCaseSource("GetCredentialsDataCsv")]

        public void BasicAuth(string username, string password)
        {
            Console.WriteLine(url + "login");
            driver.Navigate().GoToUrl(url + "login");

            PageModels.POM.LoginPage lp = new PageModels.POM.LoginPage(driver);
            // This is beacuse we have 2 classes named LoginPage one on POM other on PageFactory
            // In real life framework you will have just one type of desigm pattern (POM/PF)
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username, password);
        }



    }
}