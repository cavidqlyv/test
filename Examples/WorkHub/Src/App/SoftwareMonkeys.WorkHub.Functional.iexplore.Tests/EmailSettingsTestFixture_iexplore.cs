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
	public class EmailSettingsTestFixture_iexplore : SoftwareMonkeys.WorkHub.Functional.Tests.BaseFunctionalTestFixture
	{
		private ISelenium selenium;
		private StringBuilder verificationErrors;
	
		[SetUp]
		public void Initialize()
		{
			RemoteWebDriver driver = new OpenQA.Selenium.IE.InternetExplorerDriver();
			
			selenium = new WebDriverBackedSelenium(driver, "http://localhost/WorkHub-beta-Workspace");
			
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
		public void Test_EmailSettings()
		{
			selenium.SetTimeout("1000000");
			selenium.Open("Admin/tests/testreset.aspx?Config=true");
			selenium.WaitForPageToLoad("30000");
			selenium.Open("Admin/QuickSetup.aspx");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("link=Settings");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("link=Email Settings");
			selenium.WaitForPageToLoad("30000");
			selenium.Type("ctl00_Body_ctl00_SmtpServer", "smtp.newserver.com");
			selenium.Click("//input[@value='Update']");
			selenium.WaitForPageToLoad("30000");
			Assert.IsTrue(selenium.IsTextPresent("updated successfully"), "Text 'updated successfully' not found when it should be.");
			selenium.Click("link=Sign Out");
			selenium.WaitForPageToLoad("30000");
			selenium.Open("EmailSettings.aspx");
			Assert.IsTrue(selenium.IsTextPresent("Sign In Details"), "Text 'Sign In Details' not found when it should be.");

		}
	}
}