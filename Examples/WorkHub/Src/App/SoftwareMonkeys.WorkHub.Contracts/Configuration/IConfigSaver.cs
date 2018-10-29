/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Contracts\Configuration\IConfigSaver.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using SoftwareMonkeys.WorkHub.Entities;

namespace SoftwareMonkeys.WorkHub.Configuration
{
	/// <summary>
	/// Defines the interface of all config saver components.
	/// </summary>
	public interface IConfigSaver
	{
		/// <summary>
		/// Saves the configuration settings to the corresponding file.
		/// </summary>
		/// <param name="config">The configuration component to save.</param>
		void Save(IConfig config);
	}
}
