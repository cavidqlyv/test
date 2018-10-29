/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Data.Db4o.Tests\Db4oFilterTests.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using SoftwareMonkeys.WorkHub.Data.Tests;

namespace SoftwareMonkeys.WorkHub.Data.Db4o.Tests
{
	/// <summary>
	/// 
	/// </summary>
	public class Db4oFilterTests : FilterTests
	{
		public override void InitializeMockData()
		{
			new MockDb4oDataProviderInitializer(this).Initialize();
		}
	}
}
