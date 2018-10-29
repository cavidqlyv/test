/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Web\Controllers\ControllerState.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using SoftwareMonkeys.WorkHub.State;
using SoftwareMonkeys.WorkHub.Web.Controllers;

namespace SoftwareMonkeys.WorkHub.Web.Controllers
{
	/// <summary>
	/// Holds the current state of the available controllers.
	/// </summary>
	public class ControllerState
	{
		/// <summary>
		/// Gets a value indicating whether the controller state has been initialized.
		/// </summary>
		static public bool IsInitialized
		{
			get { return controllers != null && controllers.Count > 0; }
		}
		
		static private ControllerStateCollection controllers;
		/// <summary>
		/// Gets/sets a collection of all the available strategies which are held in state.
		/// </summary>
		static public ControllerStateCollection Controllers
		{
			get {
				if (!IsInitialized)
					throw new InvalidOperationException("The controller state has not been initialized.");
				
				if (controllers == null)
					controllers = new ControllerStateCollection();
				return controllers;  }
			set { controllers = value; }
		}
	}
}
