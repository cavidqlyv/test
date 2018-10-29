/*

====================================================================================================

This file as been imported by the Commander console and the 'Import files' script.

The source of the import is:
C:\Projects\SoftwareMonkeys\SiteStarter\Src\App\SoftwareMonkeys.SiteStarter.Business.Tests\RetrieveStrategyTests.cs

Do not edit this file or changes may be lost. Edit the source file and the changes will be imported by all projects that use it.

====================================================================================================


*/

using System;
using NUnit.Framework;
using SoftwareMonkeys.WorkHub.Entities;
using SoftwareMonkeys.WorkHub.Data;
using SoftwareMonkeys.WorkHub.Tests.Entities;
using SoftwareMonkeys.WorkHub.Business;

namespace SoftwareMonkeys.WorkHub.Business.Tests
{
	/// <summary>
	/// Tests the retriever strategy.
	/// </summary>
	[TestFixture]
	public class RetrieveStrategyTests : BaseBusinessTestFixture
	{
		
		[Test]
		public void Test_Found_ForIEntityInterface()
		{
			StrategyInfo strategy = StrategyState.Strategies["Retrieve", "IEntity"];
			
			Assert.IsNotNull(strategy);
		}
		
		[Test]
		public void Test_Retrieve_ByID()
		{
			TestArticle article = new TestArticle();
			article.ID = Guid.NewGuid();
			
			DataAccess.Data.Saver.Save(article);
			
			
			IRetrieveStrategy strategy = RetrieveStrategy.New<TestArticle>(false);
			
			IEntity foundArticle = strategy.Retrieve<TestArticle>(article.ID);
			
			Assert.IsNotNull(foundArticle, "Test article wasn't retrieved.");
		}
		
		[Test]
		public void Test_Retrieve_ByUniqueKey()
		{
			TestArticle article = new TestArticle();
			article.ID = Guid.NewGuid();
			
			DataAccess.Data.Saver.Save(article);
			
			IRetrieveStrategy strategy = RetrieveStrategy.New<TestArticle>(false);
			
			IEntity foundArticle = strategy.Retrieve<TestArticle>(article.UniqueKey);
			
			Assert.IsNotNull(foundArticle, "Test article wasn't retrieved.");
		}
		
		[Test]
		public void Test_Retrieve_ByCustomProperty()
		{
			TestArticle article = new TestArticle();
			article.ID = Guid.NewGuid();
			article.Title = "Test Title";
			
			DataAccess.Data.Saver.Save(article);
			
			IRetrieveStrategy strategy = RetrieveStrategy.New<TestArticle>(false);
			
			IEntity foundArticle = strategy.Retrieve<TestArticle>("Title", article.Title);
			
			Assert.IsNotNull(foundArticle, "Test article wasn't retrieved.");
			
		}
	}
}
