/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Contracts\Business\IUniqueValidateStrategy.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using SoftwareMonkeys.WorkHub.Entities;

namespace SoftwareMonkeys.WorkHub.Business
{
	/// <summary>
	/// Defines the interface of all "unique validation" (ie. ensuring a specific property of an entity is unique) strategies.
	/// </summary>
	public interface IUniqueValidateStrategy : IValidateStrategy
	{
		/// <summary>
		/// Validates the provided entity by ensuring that the value of the specified property is unique.
		/// </summary>
		/// <param name="entity">The entity to validate.</param>
		/// <param name="propertyName">The name of the property containing the value that must remain unique.</param>
		/// <returns>A value indicating whether the value of the specified property is unique.</returns>
		bool Validate(IEntity entity, string propertyName);
	}
}
