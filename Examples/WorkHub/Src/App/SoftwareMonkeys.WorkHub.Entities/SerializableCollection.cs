/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Entities\SerializableCollection.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using System.Collections;
using System.Xml.Serialization;

namespace SoftwareMonkeys.WorkHub.Entities
{
	/// <summary>
	/// A collection that can be serialized.
	/// </summary>
	[Serializable]
	[XmlRoot("Xml")]
	[XmlType("Xml")]
	public class SerializableCollection
	{
		private ArrayList entities = new ArrayList();
		[XmlArrayItem("Entity")]
		public ArrayList Entities
		{
			get { return entities; }
			set { entities = value; }
		}
		
		public SerializableCollection(IEntity[] entities)
		{
			foreach (IEntity entity in entities)
			{
				Entities.Add(entity);
			}
		}
		
		public SerializableCollection()
		{}
	}
}
