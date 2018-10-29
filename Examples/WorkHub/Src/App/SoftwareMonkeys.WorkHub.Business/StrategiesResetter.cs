/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Business\StrategiesResetter.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using System.IO;

namespace SoftwareMonkeys.WorkHub.Business
{
	/// <summary>
	/// Used to reset the strategies so they can be re-scanned and re-intialized.
	/// </summary>
	public class StrategiesResetter
	{
		private StrategyFileNamer fileNamer;
		/// <summary>
		/// Gets/sets the file namer used to create strategy file names/paths.
		/// </summary>
		public StrategyFileNamer FileNamer
		{
			get {
				if (fileNamer == null)
					fileNamer = new StrategyFileNamer();
				return fileNamer; }
			set { fileNamer = value; }
		}
		
		public StrategiesResetter()
		{
		}
		
		public void Reset()
		{
			// Dispose the in-memory state
			new StrategiesDisposer().Dispose();
			
			// Delete strategy info (not the actual strategies)
			File.Delete(FileNamer.StrategiesInfoFilePath);
			
			// Now the strategies can be re-scanned and re-initialized
		}
	}
}
