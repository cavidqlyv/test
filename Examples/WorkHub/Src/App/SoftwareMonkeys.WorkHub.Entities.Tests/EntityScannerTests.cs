/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Entities.Tests\EntityScannerTests.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using System.Reflection;
using NUnit.Framework;
using SoftwareMonkeys.WorkHub.Tests;

namespace SoftwareMonkeys.WorkHub.Entities.Tests
{
	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class EntityScannerTests : BaseTestFixture
	{
		public EntityScannerTests()
		{
		}
		
		[Test]
		public void Test_ContainsEntities_MatchingAssembly()
		{
			Assembly matchingAssembly = Assembly.Load("SoftwareMonkeys.WorkHub.Entities");
			
			EntityScanner scanner = new EntityScanner();
			
			bool doesMatch = scanner.ContainsEntities(matchingAssembly);
			
			Assert.IsTrue(doesMatch, "Failed to match when it should.");
		}
		
		[Test]
		public void Test_ContainsEntities_NonMatchingAssembly()
		{
			Assembly assembly = Assembly.Load("SoftwareMonkeys.WorkHub.State");
			
			EntityScanner scanner = new EntityScanner();
			
			bool doesMatch = scanner.ContainsEntities(assembly);
			
			Assert.IsFalse(doesMatch, "Matched when it shouldn't have.");
		}
		
		[Test]
		public void Test_ContainsEntities_MatchingAssembly_IncludeTestEntities()
		{
			Assembly matchingAssembly = Assembly.Load("SoftwareMonkeys.WorkHub.Entities.Tests");
			
			EntityScanner scanner = new EntityScanner();
			
			bool includeTestEntities = true;
			
			bool doesMatch = scanner.ContainsEntities(matchingAssembly, includeTestEntities);
			
			Assert.IsTrue(doesMatch, "Failed to match when it should.");
		}
		
		[Test]
		public void Test_ContainsEntities_NonMatchingAssembly_ExcludeTestEntities()
		{
			Assembly assembly = Assembly.Load("SoftwareMonkeys.WorkHub.Entities.Tests");
			
			EntityScanner scanner = new EntityScanner();
			
			bool includeTestEntities = false;
			
			bool doesMatch = scanner.ContainsEntities(assembly, includeTestEntities);
			
			Assert.IsFalse(doesMatch, "Matched when it shouldn't have.");
		}
	}
}
