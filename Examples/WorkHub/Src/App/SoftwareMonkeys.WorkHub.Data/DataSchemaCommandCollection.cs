/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Data\DataSchemaCommandCollection.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SoftwareMonkeys.WorkHub.Data
{
	/// <summary>
	/// Holds a collection of DataSchemaCommand objects and presents them for interaction by other components.
	/// </summary>
	[XmlType("Commands")]
	[XmlRoot("Commands")]
	public class DataSchemaCommandCollection : List<DataSchemaCommand>
	{
		public DataSchemaCommandCollection()
		{
		}
	}
}
