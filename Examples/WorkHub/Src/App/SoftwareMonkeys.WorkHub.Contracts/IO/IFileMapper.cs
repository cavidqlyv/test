/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Contracts\IO\IFileMapper.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;

namespace SoftwareMonkeys.WorkHub.IO
{
	/// <summary>
	/// Defines the interface of all file mapper components.
	/// </summary>
	public interface IFileMapper
	{
		/// <summary>
		/// Gets/sets the server relative application path.
		/// </summary>
		string ApplicationPath {get;set;}
		
		/// <summary>
		/// Maps the provided relative path to the corresponding physical path.
		/// </summary>
		/// <param name="relativePath">The relative path to map.</param>
		/// <returns>An absolute version of the provided relative path.</returns>
		string MapPath(string relativePath);
		
		/// <summary>
		/// Maps the provided application relative path to the corresponding physical path.
		/// </summary>
		/// <param name="applicationRelativePath">The application relative path to map.</param>
		/// <returns>An absolute version of the provided application relative path.</returns>
		string MapApplicationRelativePath(string applicationRelativePath);
	}
}
