/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Business\StrategyState.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;

namespace SoftwareMonkeys.WorkHub.Business
{
	/// <summary>
	/// Holds the state of the business strategies.
	/// </summary>
	static public class StrategyState
	{
		/// <summary>
		/// Gets a value indicating whether the strategy state has been initialized.
		/// </summary>
		static public bool IsInitialized
		{
			get { return strategies != null && strategies.Count > 0; }
		}
		
		static private StrategyStateNameValueCollection strategies;
		/// <summary>
		/// Gets/sets a collection of all the available strategies which are held in state.
		/// </summary>
		static public StrategyStateNameValueCollection Strategies
		{
			get {
				if (!IsInitialized)
					throw new InvalidOperationException("The business strategy state has not been initialized.");
				
				if (strategies == null)
					strategies = new StrategyStateNameValueCollection();
				return strategies;  }
			set { strategies = value; }
		}
	}
}
