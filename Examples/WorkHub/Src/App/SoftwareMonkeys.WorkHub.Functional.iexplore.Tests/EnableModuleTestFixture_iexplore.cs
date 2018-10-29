using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Selenium;
using System.Net;
using System.Net.Sockets;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SoftwareMonkeys.WorkHub.Functional.iexplore.Tests
{
	[TestFixture]
	public class EnableModuleTestFixture_iexplore : SoftwareMonkeys.WorkHub.Functional.Tests.BaseFunctionalTestFixture
	{
		private ISelenium selenium;
		private StringBuilder verificationErrors;
	
		[SetUp]
		public void Initialize()
		{
			RemoteWebDriver driver = new OpenQA.Selenium.IE.InternetExplorerDriver();
			
			selenium = new WebDriverBackedSelenium(driver, "http://localhost/WorkHub");
			
			selenium.Start();
			verificationErrors = new StringBuilder();
		}
		
		[TearDown]
		public void Dispose()
		{
			try
			{
				selenium.Stop();
			}
			catch (Exception)
			{
				// Ignore errors if unable to close the browser
			}
			Assert.AreEqual("", verificationErrors.ToString());
		}
		
		[Test]
		public void Test_EnableModule()
		{
			selenium.SetTimeout("1000000");
			selenium.Open("Admin/tests/testreset.aspx");
			selenium.WaitForPageToLoad("30000");
			selenium.Open("Admin/QuickSetup.aspx");
			selenium.WaitForPageToLoad("30000");
			Assert.IsTrue(selenium.IsTextPresent("Component Types"), "Text 'Component Types' not found when it should be.");
			selenium.Click("link=Utilities");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("link=Modules");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("link=Disable");
			selenium.WaitForPageToLoad("30000");
			Assert.IsTrue(selenium.IsTextPresent("disabled successfully"), "Text 'disabled successfully' not found when it should be.");
			selenium.Click("link=Home");
			selenium.WaitForPageToLoad("30000");
			Assert.IsFalse(selenium.IsTextPresent("Component Types"), "Text 'Component Types' found when it shouldn't be.");
			selenium.Click("link=Utilities");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("link=Modules");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("link=Enable");
			selenium.WaitForPageToLoad("30000");
			Assert.IsTrue(selenium.IsTextPresent("enabled successfully"), "Text 'enabled successfully' not found when it should be.");
			selenium.Click("link=Home");
			selenium.WaitForPageToLoad("30000");
			Assert.IsTrue(selenium.IsTextPresent("Technical"), "Text 'Technical' not found when it should be.");
			Assert.IsTrue(selenium.IsTextPresent("Component Types"), "Text 'Component Types' not found when it should be.");

		}
	}
}