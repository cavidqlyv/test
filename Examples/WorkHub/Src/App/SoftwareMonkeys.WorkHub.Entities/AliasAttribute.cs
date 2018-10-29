/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Entities\AliasAttribute.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;

namespace SoftwareMonkeys.WorkHub.Entities
{
	/// <summary>
	/// Used to define the alias for certain entities. (Example: The alias for "IUser" is "User".)
	/// </summary>
	public class AliasAttribute : Attribute
	{
		private string aliasTypeName;
		/// <summary>
		/// Gets/sets the short name of the alias type.
		/// </summary>
		public string AliasTypeName
		{
			get { return aliasTypeName; }
			set { aliasTypeName = value; }
		}
		
		public AliasAttribute()
		{
			
		}
		
		public AliasAttribute(string aliasTypeName)
		{
			AliasTypeName = aliasTypeName;
		}
	}
}
