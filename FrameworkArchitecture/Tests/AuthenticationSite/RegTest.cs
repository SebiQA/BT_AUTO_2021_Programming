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
using OpenQA.Selenium.Support.UI;

namespace NUnit_Auto_2022.Tests
{
    class RegTest : BaseTest
    {

        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetRegCredentialsDataCsv()


        {
            string path = "TestData\\RegCredentialsData.csv";
            using (var reader = new StreamReader(path))
            {
                var index = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (index > 0)
                    {
                        yield return new TestCaseData(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]);
                    }
                    index++;
                }
            }
        }

        [Test, TestCaseSource("GetRegCredentialsDataCsv")]

        public void Registration(string username, string password, string passconfirm, string firstName, string lastName, string email, string dob, string nationality)
        {
            Console.WriteLine(url + "registration");
            driver.Navigate().GoToUrl(url + "registration");

            PageModels.POM.RegisterPage lp = new PageModels.POM.RegisterPage(driver);

            Assert.AreEqual("Registration", lp.CheckPage());
            lp.Registration(username, password, passconfirm, firstName, lastName, email, dob, nationality);
        }



    }
}