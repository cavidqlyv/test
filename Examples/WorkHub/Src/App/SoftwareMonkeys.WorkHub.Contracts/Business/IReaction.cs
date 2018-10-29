/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Contracts\Business\IReaction.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using SoftwareMonkeys.WorkHub.Entities;

namespace SoftwareMonkeys.WorkHub.Business
{
	/// <summary>
	/// Defines the interface of all business reaction components.
	/// </summary>
	public interface IReaction
	{
		/// <summary>
		/// Gets/sets the name of the type involved in the reaction.
		/// </summary>
		string TypeName {get;set;}
		
		string Action { get; }
		
		void React(IEntity entity);
	}
}
