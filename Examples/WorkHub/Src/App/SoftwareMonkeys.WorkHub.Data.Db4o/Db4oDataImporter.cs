/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Data.Db4o\Db4oDataImporter.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;

namespace SoftwareMonkeys.WorkHub.Data.Db4o
{
	/// <summary>
	/// Imports data from XML files to the data stores.
	/// </summary>
	public class Db4oDataImporter : DataImporter
	{
		/// <summary>
		/// Sets the data provider and data store of the adapter.
		/// </summary>
		/// <param name="provider">The data provider of adapter.</param>
		/// <param name="store">The data store to tie the adapter to, or [null] to automatically select store.</param>
		public Db4oDataImporter(Db4oDataProvider provider, Db4oDataStore store)
		{
			Initialize(provider, store);
		}
	}
}
