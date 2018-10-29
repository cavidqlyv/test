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

namespace SoftwareMonkeys.WorkHub.Functional.firefox.Tests
{
	[TestFixture]
	public class ErrorsTestFixture_firefox : SoftwareMonkeys.WorkHub.Functional.Tests.BaseFunctionalTestFixture
	{
		private ISelenium selenium;
		private StringBuilder verificationErrors;
	
		[SetUp]
		public void Initialize()
		{
			RemoteWebDriver driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
			
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
		public void Test_Errors()
		{
			selenium.SetTimeout("1000000");
			selenium.Open("Admin/tests/testreset.aspx?Log=true");
			selenium.WaitForPageToLoad("30000");
			selenium.Open("Admin/QuickSetup.aspx");
			selenium.WaitForPageToLoad("30000");
			selenium.Open("NonExistentPage.aspx");
			selenium.WaitForPageToLoad("30000");
			Assert.IsTrue(selenium.IsTextPresent("Oops"), "Text 'Oops' not found when it should be.");
			selenium.Open("Admin/Errors.aspx");
			Assert.IsTrue(selenium.IsTextPresent("Errors"), "Text 'Errors' not found when it should be.");
			Assert.IsTrue(selenium.IsTextPresent("NonExistentPage.aspx"), "Text 'NonExistentPage.aspx' not found when it should be.");
			selenium.Open("User-SignOut.aspx");
			selenium.Open("Admin/Errors.aspx");
			Assert.IsTrue(selenium.IsTextPresent("Sign In Details"), "Text 'Sign In Details' not found when it should be.");

		}
	}
}