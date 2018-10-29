/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Web\Controllers\CreateUserController.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using SoftwareMonkeys.WorkHub.Entities;
using SoftwareMonkeys.WorkHub.Business;
using SoftwareMonkeys.WorkHub.Business.Security;
using SoftwareMonkeys.WorkHub.Web.Navigation;
using SoftwareMonkeys.WorkHub.Web.Properties;
using SoftwareMonkeys.WorkHub.Web.Security;
using SoftwareMonkeys.WorkHub.Diagnostics;
using SoftwareMonkeys.WorkHub.Configuration;
using SoftwareMonkeys.WorkHub.Web.Validation;

namespace SoftwareMonkeys.WorkHub.Web.Controllers
{
	/// <summary>
	/// 
	/// </summary>
	[Controller("Create", "User")]
	public class CreateUserController : CreateController
	{		
		public CreateUserController()
		{
			Validation = new UserValidation();
		}
		
		public override bool ExecuteSave(SoftwareMonkeys.WorkHub.Entities.IEntity entity)
		{
			if (entity is User)
			{
				return ExecuteSave((User)entity);
			}
			else
				throw new ArgumentException("The provided entity type '" + entity.GetType().FullName + "' is not supported. The entity must be of type 'User'.");
		}
		
		public virtual bool ExecuteSave(User user)
		{
			bool success = false;
			
			using (LogGroup logGroup = LogGroup.Start("Saving the new user.", NLog.LogLevel.Debug))
			{
				// TODO: Clean up
				
				LogWriter.Debug("Auto navigate: " + AutoNavigate.ToString());
				
				user.Password = Crypter.EncryptPassword(user.Password);
								
				success = base.ExecuteSave(user);
				
				LogWriter.Debug("Success: " + success.ToString());
				
				if (!success)
				{
					LogWriter.Debug("Failed to save (username in use).");
				}
			}
			
			return success;
		}
		
		public override void NavigateAfterSave()
		{	
				Navigator.Current.Go("Index", "User");
		}
	}
}
