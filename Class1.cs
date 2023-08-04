using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace Bhargav_Rohit_8877589_Assignment04
{
    [TestFixture]

    public class Class1
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void insuranceQuote01ValidDataAge25DrivingExp3Accidents0()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(870, 654);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargav33@gmail.com");
            driver.FindElement(By.Id("phone")).Click();

            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.CssSelector("html")).Click();

            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(3)")).Click();
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("finalQuote")).Click();
            driver.FindElement(By.Id("addForm")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$4500"));
            }
        }

        [Test]
        public void insuranceQuote02ValidDataAge25DrivingExp3Accidents2()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(870, 654);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargav33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("2");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.Id("finalQuote")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$4500"));
            }
        }
        [Test]
        public void insuranceQuote03ValidDataAge35DrivingExp10Accidents4()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(874, 661);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargav33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("10");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("4");
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
            }
        }
        [Test]
        public void insuranceQuote04InvalidPhoneNumberAge27DrivingExp3Accidents0()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(878, 665);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("4375591113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargavrohit33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("27");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.CssSelector(".card-body > .form-group:nth-child(3)")).Click();
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
        }
        [Test]
        public void insuranceQuote05InvalidEmailAddressAge28DrivingExp3Accidents0()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(870, 654);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargav.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("28");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
        }
        [Test]
        public void insuranceQuote06InvalidPostalCodeAge35DrivingExp17Accidents1()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(870, 654);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargav33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("17");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.CssSelector(".col-md-2")).Click();
            Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
        }
        [Test]
        public void insuranceQuote07AgeOmittedDrivingExp5Accidents0()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(872, 656);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargav33@gmail.com");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("5");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                var element = driver.FindElement(By.Id("btnSubmit"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.TagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
        }
        [Test]
        public void insuranceQuote08AccidentsOmittedAge37DrivingExp8()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(872, 656);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.CssSelector(".form-row:nth-child(4)")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargav33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("37");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("8");
            driver.FindElement(By.Id("btnSubmit")).Click();
            Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
        }
        [Test]
        public void insuranceQuote09DrivingExpOmittedAge45Accidents0()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(872, 656);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargav33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("45");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
        }
        [Test]
        public void insuranceQuote10AgeLessThan16Age15DrivingExp2Accidents0()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(873, 657);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("address")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("address")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).SendKeys("bhargav33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("15");
            driver.FindElement(By.CssSelector(".card-body")).Click();
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("2");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 16."));
        }
        [Test]
        public void insuranceQuote11DrivingExpAndAgeDiffMoreThan16Age50DrivingExp35Accidents2()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(870, 654);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargav33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("50");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("35");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("2");
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
            }
        }
        [Test]
        public void insuranceQuote12InvalidAgeAgeMinus17DrivingExp2Accidents0()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(870, 654);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).SendKeys("60 Fredrick Street,  N2H 0C7");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).SendKeys("bhargavrohit33@gmail.com");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Fredrick Street");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("-16");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("2");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 16."));
        }
        [Test]
        public void insuranceQuote13InvalidExpAge25DrivingExp50Accidents2()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(873, 657);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).SendKeys("bhargavrohit33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("50");
            driver.FindElement(By.Id("accidents")).SendKeys("2");
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
            }
        }
        [Test]
        public void insuranceQuote14InvalidExpAge18DrivingExpMinus30Accidents0()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(877, 661);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick street");
            driver.FindElement(By.Id("address")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("address")).SendKeys("60 Frederick Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("province")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("bhargavrohit33@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("18");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("-30");
            driver.FindElement(By.Id("accidents")).Click();
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector("html"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 0."));
        }

        [Test]
        public void insuranceQuote15Age18DrivingExp30Accidents0()
        {
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
            driver.Manage().Window.Size = new System.Drawing.Size(870, 654);
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Bhargav");
            driver.FindElement(By.Id("lastName")).SendKeys("Rohit");
            driver.FindElement(By.Id("address")).SendKeys("60 Fredrick Street,  N2H 0C7");
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).SendKeys("N2H 0C7");
    
            driver.FindElement(By.Id("email")).SendKeys("bhargavrohit33@gmail.com");
            driver.FindElement(By.Id("address")).Click();
           
            driver.FindElement(By.Id("address")).SendKeys("60 Fredrick Street");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("437-559-1113");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("18");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("30");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
            }

        }

    }
}