/****** Object:  Table [dbo].[tblPriority]    Script Date: 7/9/2011 4:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPriority](
	[PriorityID] [int] IDENTITY(1,1) NOT NULL,
	[PriorityName] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
INSERT INTO [dbo].[tblPriority](PriorityName) VALUES('High')
INSERT INTO [dbo].[tblPriority](PriorityName) VALUES('Low')
INSERT INTO [dbo].[tblPriority](PriorityName) VALUES('Normal')
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblStatus]    Script Date: 7/9/2011 4:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblStatus](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
INSERT INTO [dbo].[tblStatus](StatusName) VALUES('InProgress')
INSERT INTO [dbo].[tblStatus](StatusName) VALUES('Deferred')
INSERT INTO [dbo].[tblStatus](StatusName) VALUES('Completed')
INSERT INTO [dbo].[tblStatus](StatusName) VALUES('Closed')
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTaskActivity]    Script Date: 7/9/2011 4:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTaskActivity](
	[TaskID] [int] IDENTITY(1,1) NOT NULL,
	[TaskName] [varchar](50) NOT NULL,
	[Priority] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[AssignedTo] [int] NOT NULL,
	[TaskCreatedOn] [date] NOT NULL,
	[EstimatedTime] [int] NOT NULL,
	[ActualTime] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 7/9/2011 4:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
INSERT INTO [dbo].[tblUser](UserName) VALUES('Shiva')
INSERT INTO [dbo].[tblUser](UserName) VALUES('Amit')
INSERT INTO [dbo].[tblUser](UserName) VALUES('Arjuna')
INSERT INTO [dbo].[tblUser](UserName) VALUES('Shakti')
SET ANSI_PADDING OFF
GO

GO
/****** Object:  StoredProcedure [dbo].[usp_GetPriority]    Script Date: 7/9/2011 4:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetPriority] 	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *  from tblPriority 
END

GO
/****** Object:  StoredProcedure [dbo].[usp_GetStatus]    Script Date: 7/9/2011 4:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetStatus]
	-- Add the parameters for the stored procedure here
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from tblStatus
END

GO
/****** Object:  StoredProcedure [dbo].[usp_GetTaskList]    Script Date: 7/9/2011 4:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetTaskList] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		t.TaskId
		,t.TaskName
		,p.PriorityID
		,p.PriorityName
		,s.StatusID
		,s.StatusName
		,u.UserID
		,u.UserName
		,t.TaskCreatedOn
		,t.EstimatedTime
		,t.ActualTime
	From tblTaskActivity t
	Join tblPriority p ON t.Priority = p.PriorityID
	Join tblStatus s ON t.Status = s.StatusID
	Join tblUser u ON t.AssignedTo =u.UserID
END

GO
/****** Object:  StoredProcedure [dbo].[usp_GetUser]    Script Date: 7/9/2011 4:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetUser]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from tblUser
END

GO
/****** Object:  StoredProcedure [dbo].[usp_SaveTask]    Script Date: 7/9/2011 4:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_InsertTask]
	-- Add the parameters for the stored procedure here
	(
	 @TaskName varchar(50)
	,@PriorityId int
	,@StatusId int
	,@UserId int
	,@TaskCreation datetime
	,@EstimatedTime int
	,@ActualTime int)
AS
BEGIN
			-- Insert statements for procedure here
			INSERT INTO [dbo].[tblTaskActivity]
				   ([TaskName]
				   ,[Priority]
				   ,[Status]
				   ,[AssignedTo]
				   ,[TaskCreatedOn]
				   ,[EstimatedTime]
				   ,[ActualTime])
			 VALUES
			 (
				@TaskName
				,@PriorityId
				,@StatusId
				,@UserId
				,@TaskCreation
				,@EstimatedTime
				,@ActualTime
			)	
	SELECT SCOPE_IDENTITY() as NewTaskId 	
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateTask] 
-- Add the parameters for the stored procedure here
	(
	@TaskId int
	,@PriorityId int
	,@StatusId int
	,@UserId int
	,@TaskCreation datetime
	,@EstimatedTime int
	,@ActualTime int)
AS
BEGIN

			Update [dbo].[tblTaskActivity]
			Set
				[Priority] = @PriorityId
				,[Status] = @StatusId
				   ,[AssignedTo] = @UserId
				   ,[TaskCreatedOn] = @TaskCreation
				   ,[EstimatedTime] = @EstimatedTime
				   ,[ActualTime] = @ActualTime
			Where [TaskID] = @TaskId
END
GO