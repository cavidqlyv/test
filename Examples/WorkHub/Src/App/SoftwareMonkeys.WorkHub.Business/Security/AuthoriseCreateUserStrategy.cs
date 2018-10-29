/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Business\Security\AuthoriseCreateUserStrategy.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using SoftwareMonkeys.WorkHub.Entities;
using System.Collections.Generic;

namespace SoftwareMonkeys.WorkHub.Business.Security
{
	/// <summary>
	/// Used to check whether the current user is authorised to create a user.
	/// </summary>
	[AuthoriseStrategy("Create", "User")]
	public class AuthoriseCreateUserStrategy : AuthoriseCreateStrategy
	{
		/// <summary>
		/// Checks whether the current user is authorised to create an entity of the specified type.
		/// </summary>
		/// <param name="shortTypeName">The type of entity being created.</param>
		/// <returns>A value indicating whether the current user is authorised to create an entity of the specified type.</returns>
		public override bool IsAuthorised(string shortTypeName)
		{
			bool isAuthenticated = AuthenticationState.IsAuthenticated;
			
			bool allowRegistration = Configuration.Config.Application.Settings.GetBool("EnableUserRegistration");
			
			return isAuthenticated
				|| allowRegistration;
		}
		
		/// <summary>
		/// Checks whether the current user is authorised to create the provided entity.
		/// </summary>
		/// <param name="entity">The entity to be created.</param>
		/// <returns>A value indicating whether the current user is authorised to create the provided entity.</returns>
		public override bool IsAuthorised(IEntity entity)
		{
			if (entity == null)
				throw new ArgumentNullException("entity");
		
			return IsAuthorised(entity.ShortTypeName);	
		}
		
		#region New functions
		
		/// <summary>
		/// Creates a new strategy for authorising the create of an entity of the specified type.
		/// </summary>
		static public IAuthoriseCreateStrategy New()
		{
			return StrategyState.Strategies.Creator.New<IAuthoriseCreateStrategy>("AuthoriseCreate", "User");
		}
		#endregion
	}
}
