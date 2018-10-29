/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Data.Db4o.Tests\Db4oDataSaverTests.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using NUnit.Framework;
using SoftwareMonkeys.WorkHub.Data.Tests;

namespace SoftwareMonkeys.WorkHub.Data.Db4o.Tests
{
	[TestFixture]
	public class Db4oDataSaverTests : DataSaverTests
	{
		public override void InitializeMockData()
		{
			new MockDb4oDataProviderInitializer(this).Initialize();
		}
		
		[Test]
		public override void Test_Save_SetsCountPropertyForReference()
		{
			base.Test_Save_SetsCountPropertyForReference();
		}
		
		[Test]
		public override void Test_Save_EntityReference()
		{
			base.Test_Save_EntityReference();
		}
	}
}
