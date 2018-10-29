/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Business.Tests\Entities\MockSubInterfaceEntity.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using SoftwareMonkeys.WorkHub.Entities;

namespace SoftwareMonkeys.WorkHub.Business.Tests.Entities
{
	/// <summary>
	/// A mock entity used for testing strategy matching. Implements IMockSubInterface. 
	/// </summary>
	[Entity("MockSubInterfaceEntity")]
	public class MockSubInterfaceEntity : BaseEntity, IMockSubInterface
	{
		public MockSubInterfaceEntity()
		{
		}
	}
}
