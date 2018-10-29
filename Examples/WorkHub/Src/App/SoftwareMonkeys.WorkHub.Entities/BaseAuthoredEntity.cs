/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Entities\BaseAuthoredEntity.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;

namespace SoftwareMonkeys.WorkHub.Entities
{
	/// <summary>
	/// A base class for entities that are authored by a particular user. The author generally has ownership and the rights associated with it.
	/// </summary>
	[Serializable]
	public class BaseAuthoredEntity : BaseEntity, IAuthored
	{
		private User author;
		/// <summary>
		/// Gets/sets the author of the entity.
		/// </summary>
		[Reference]
		public User Author
		{
			get { return author; } 
			set { author = value; }
		}
		
		IUser IAuthored.Author {
			get {
				return Author;
			}
			set {
				Author = (User)value;
			}
		}
		
		private bool isPublic;
		/// <summary>
		/// Gets/sets a value indicating whether the entity is publicly accessible.
		/// </summary>
		public bool IsPublic
		{
			get { return isPublic; }
			set { isPublic = value; }
		}
		
		public BaseAuthoredEntity()
		{
		}
	}
}
