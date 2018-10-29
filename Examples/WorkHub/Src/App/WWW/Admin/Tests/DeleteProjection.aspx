<%--
====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\WWW\Admin\Tests\DeleteProjection.aspx

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================

--%>

<%@ Page Language="C#" autoeventwireup="true" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Web.Projections" %>
<%@ Import namespace="System.IO" %>
<script runat="server">

public string OutputText = "Done";

private void Page_Load(object sender, EventArgs e)
{
	string projectionName = Request.QueryString["Projection"];
	if (projectionName != null && projectionName != String.Empty)
	{
		ProjectionInfo info = null;
		if (ProjectionState.Projections.Contains(projectionName))
			info = ProjectionState.Projections[projectionName];
	
		// If not found create a dummy object which holds the path to the files
		// just in case the files exist while the state objects don't
		if (info == null)
		{
			info = new ProjectionInfo();
			info.Name = projectionName;
			info.ProjectionFilePath = new ProjectionFileNamer().CreateRelativeProjectionFilePath(projectionName);
		}

		string filePath = new ProjectionFileNamer().CreateProjectionFilePath(info);
		
		File.Delete(filePath);
		
		ProjectionState.Projections.Remove(info);
		
		new ProjectionSaver().SaveInfoToFile(ProjectionState.Projections.ToArray());
		
	}
	else
		throw new Exception("No projection specified.");
}

</script>
<html>
<head runat="server">
</head>
<body>
<form runat="server">
<%= OutputText %>
</form>
</body>
</html>
