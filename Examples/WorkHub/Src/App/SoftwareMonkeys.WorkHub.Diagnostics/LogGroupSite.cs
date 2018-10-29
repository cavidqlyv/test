/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Diagnostics\LogGroupSite.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections;

namespace SoftwareMonkeys.WorkHub.Diagnostics
{
	/// <summary>
	/// Helps with the diagnostics tracing.
	/// </summary>
	public class LogGroupSite : ISite
    	{
		private IComponent component;
	        private IContainer container;
	        private bool designMode;
	        private string componentName;
	
	        public LogGroupSite(IContainer container, IComponent component)
	        {
	            this.component = component;
	            this.container = container;
	            this.designMode = false;
	            this.componentName = null;
	        }
	
	        //Support the ISite interface.
	        public virtual IComponent Component
	        {
	            get
	            {
	                return component;
	            }
	        }
	
	        public virtual IContainer Container
	        {
	            get
	            {
	                return container;
;
	            }
	        }
	        
	        public virtual bool DesignMode
	        {
	            get
	            {
	                return designMode;
	            }
	        }
	
	        public virtual string Name
	        {
	            get
	            {
	                return componentName;
	            }
	
	            set
	            {
	                componentName = value;
	            }
	        }
	
	        //Support the IServiceProvider interface.
	        public virtual object GetService(Type serviceType)
	        {
	            //This example does not use any service object.
	            return null;
	        }

	}

}
