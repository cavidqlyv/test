/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Business\Security\AuthoriseReferenceStrategyInfo.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using SoftwareMonkeys.WorkHub.Entities;

namespace SoftwareMonkeys.WorkHub.Business.Security
{
	/// <summary>
	/// 
	/// </summary>
	[Serializable]
	public class AuthoriseReferenceStrategyInfo : StrategyInfo
	{
		private string referencedTypeName = String.Empty;
		public string ReferencedTypeName
		{
			get { return referencedTypeName; }
			set { referencedTypeName = value; }
		}
		
		private Type referencedType;
		public Type ReferencedType
		{
			get {
				if (referencedType == null && ReferencedTypeName != String.Empty && EntityState.IsType(ReferencedTypeName))
					referencedType = EntityState.GetType(ReferencedTypeName);
				return referencedType; }
		}
		
		private string referenceProperty = String.Empty;
		public string ReferenceProperty
		{
			get { return referenceProperty; }
			set { referenceProperty = value; }
		}
		
		private string mirrorProperty = String.Empty;
		public string MirrorProperty
		{
			get { return mirrorProperty; }
			set { mirrorProperty = value; }
		}
		
		public AuthoriseReferenceStrategyInfo()
		{
			Action = "AuthoriseReference";
		}
	}
}
