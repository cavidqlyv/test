<%--
====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\WWW\Admin\Tests\ClearData.aspx

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================

--%>

<%@ Page Language="C#" autoeventwireup="true" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Entities" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Business" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Configuration" %>
<%@ Import Namespace="System.Reflection" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Web" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Web.WebControls" %>
<%@ Import namespace="System.IO" %>
<%@ Import namespace="System.Xml" %>
<%@ Import namespace="System.Xml.Serialization" %>
<%@ Import namespace="SoftwareMonkeys.WorkHub.Data" %>
<%@ Import namespace="SoftwareMonkeys.WorkHub.Diagnostics" %>
<%@ Import namespace="SoftwareMonkeys.WorkHub.State" %>
<script runat="server">

public string DataDirectoryPath
{
	get { return StateAccess.State.PhysicalApplicationPath + Path.DirectorySeparatorChar + "App_Data"; }
}

private void Page_Init(object sender, EventArgs e)
{
}

private void Page_Load(object sender, EventArgs e)
{
	DeleteLogs();
	DeleteDb4oFiles();
	DeleteAppConfig();
	DeleteSiteMap();
	DeleteVersion();
	DeleteCaches();
	DeleteSuspended();
	DeleteImport();
	DeleteImported();
	DeletePersonalization();
}


private void DeleteLogs()
{
	string dataDirectory = DataDirectoryPath;

	string logsDirectory = dataDirectory + Path.DirectorySeparatorChar + "Logs";

	if (Directory.Exists(logsDirectory))
		Directory.Delete(logsDirectory, true);
}

private void DeleteSuspended()
{
	string dataDirectory = DataDirectoryPath;

	string suspendedDirectory = dataDirectory + Path.DirectorySeparatorChar + "Suspended";

	if (Directory.Exists(suspendedDirectory ))
		Directory.Delete(suspendedDirectory , true);
}


private void DeleteExport()
{
	string dataDirectory = DataDirectoryPath;

	string exportDirectory = dataDirectory + Path.DirectorySeparatorChar + "Export";

	if (Directory.Exists(exportDirectory))
		Directory.Delete(exportDirectory, true);
}

private void DeleteImport()
{
	string dataDirectory = DataDirectoryPath;

	string importDirectory = dataDirectory + Path.DirectorySeparatorChar + "Import";

	if (Directory.Exists(importDirectory))
		Directory.Delete(importDirectory, true);
}

private void DeleteImported()
{
	string dataDirectory = DataDirectoryPath;

	string importedDirectory = dataDirectory + Path.DirectorySeparatorChar + "Imported";

	if (Directory.Exists(importedDirectory))
		Directory.Delete(importedDirectory, true);
}

private void DeletePersonalization()
{
	string dataDirectory = DataDirectoryPath;

	string personalizationDirectory = dataDirectory + Path.DirectorySeparatorChar + "Personalization_Data";

	if (Directory.Exists(personalizationDirectory))
		Directory.Delete(personalizationDirectory, true);
}

private void DeleteCaches()
{
	string[] caches = new string[]
	{
		"Strategies",
		"Entities",
		"Controllers",
		"Projections",
		"Parts"
	};

	string dataDirectory = DataDirectoryPath;

	foreach (string cache in caches)
	{
		string cacheDirectory = dataDirectory + Path.DirectorySeparatorChar + cache;

		if (Directory.Exists(cacheDirectory))
			Directory.Delete(cacheDirectory, true);
	}
}


private void DeleteDb4oFiles()
{
	if (DataAccess.IsInitialized)
		DataAccess.Dispose(true);

	string dataDirectory = DataDirectoryPath;

	foreach (string file in Directory.GetFiles(dataDirectory, "*.db4o"))
	{
		File.Delete(file);
	}
}

private void DeleteAppConfig()
{
	if (Config.IsInitialized)
	{
		string configPath = Config.Application.FilePath;

		if (File.Exists(configPath))
			File.Delete(configPath);
	}
}

private void DeleteSiteMap()
{
	string dataDirectory = DataDirectoryPath;

	foreach (string file in Directory.GetFiles(dataDirectory, "*.sitemap"))
	{
		if (file.ToLower().IndexOf("default.sitemap") == -1)
		{
			File.Delete(file);
		}
	}
}

private void DeleteVersion()
{
	string dataDirectory = DataDirectoryPath;

	foreach (string file in Directory.GetFiles(dataDirectory, "*.number"))
	{
		File.Delete(file);
	}
}
</script>
<html>
<head runat="server">
</head>
<body>
<form runat="server">
Done
</form>
</body>
</html>
