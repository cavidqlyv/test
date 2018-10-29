<%--
====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\WWW\Projections\User-MockCreate.ascx

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================

--%>

<%@ Control Language="C#" ClassName="MockCreateUserProjection" Inherits="SoftwareMonkeys.WorkHub.Web.Projections.BaseProjection" %>
<%@ Register Namespace="SoftwareMonkeys.WorkHub.Web.WebControls" Assembly="SoftwareMonkeys.WorkHub.Web" TagPrefix="cc" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Business" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Web" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Web.Security" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Web.WebControls" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Web.Properties" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Data" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Diagnostics" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Entities" %>
<%@ Import Namespace="SoftwareMonkeys.WorkHub.Business.Security" %>
<%@ Import Namespace="System.Collections.Generic" %>
<script runat="server">
	public int TotalUsers = 1;

    private void Page_Load(object sender, EventArgs e)
    {
	CreateMockUsers();
    }

	private void CreateMockUsers()
	{
		if (Request.QueryString["Total"] != null)
			TotalUsers = Int32.Parse(Request.QueryString["Total"]);

		using (Batch batch = BatchState.StartBatch())
		{
			CreateMockUsers(TotalUsers);
		}
	}

	private void CreateMockUsers(int total)
	{
		for (int i = 0; i < total; i++)
		{	
			CreateMockUser(i);
		}
	}

	private void CreateMockUser(int position)
	{
		int number = position+1;

		User user = CreateStrategy.New<User>(false).Create<User>();
		user.ID = Guid.NewGuid();
		user.Username = "Username" + number;
		user.FirstName = "FirstName" + number;
		user.LastName = "LastName" + number;
		user.Email = "test" + position.ToString() + "@softwaremonkeys.net";
		user.Password = Crypter.EncryptPassword("pass");
		user.IsApproved = true;
		user.EnableNotifications = true;
		
		SaveStrategy.New(user, false).Save(user);
	}
	
	  public override void InitializeInfo()
	  {
	  	MenuTitle = "MockCreateUser";
	  	MenuCategory = "TestCategory";
	  	ShowOnMenu = false;
	  	ActionAlias = "Create";
	  }    
</script>
<h1>Creating Mock Users</h1>
<p><b>...done!</b></p>
<p><%= TotalUsers %> users created</p>
               