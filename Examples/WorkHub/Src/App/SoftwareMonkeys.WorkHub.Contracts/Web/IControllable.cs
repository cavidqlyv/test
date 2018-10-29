/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Contracts\Web\IControllable.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using System.Collections.Generic;
using SoftwareMonkeys.WorkHub.Business;


namespace SoftwareMonkeys.WorkHub.Web
{
	/// <summary>
	/// Defines the interface of all controllable objects (such as projections).
	/// </summary>
	public interface IControllable
	{
		object DataSource { get; set; }
		
		string WindowTitle { get;set; }
		
		ICommandInfo Command { get;set; }
			
		void CheckCommand();
		
		bool RequireAuthorisation {get;set;}
	}
}
