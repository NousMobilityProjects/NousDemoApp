using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace NousDemoAppTest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]         public void WelcomeTextIsDisplayed()         {
            AppResult[] results3 = app.WaitForElement(c => c.Marked("CICD Demo Project!"));
            Assert.IsTrue(results3.Any());         }
    }
}
