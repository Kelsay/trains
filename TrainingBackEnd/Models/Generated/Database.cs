



















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `umbracoDbDSN`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `server=UNDERCITY\SQLEXPRESS;database=Training;user id=training;password=Dupa123!`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace umbracoDbDSN
{

	public partial class umbracoDbDSNDB : Database
	{
		public umbracoDbDSNDB() 
			: base("umbracoDbDSN")
		{
			CommonConstruct();
		}

		public umbracoDbDSNDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			umbracoDbDSNDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static umbracoDbDSNDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new umbracoDbDSNDB();
        }

		[ThreadStatic] static umbracoDbDSNDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static umbracoDbDSNDB repo { get { return umbracoDbDSNDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    
	[TableName("cmsPropertyData")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsPropertyDatum : umbracoDbDSNDB.Record<cmsPropertyDatum>  
    {



		[Column] public int id { get; set; }





		[Column] public int contentNodeId { get; set; }





		[Column] public Guid? versionId { get; set; }





		[Column] public int propertytypeid { get; set; }





		[Column] public int? dataInt { get; set; }





		[Column] public DateTime? dataDate { get; set; }





		[Column] public string dataNvarchar { get; set; }





		[Column] public string dataNtext { get; set; }



	}

    
	[TableName("umbracoRelationType")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class umbracoRelationType : umbracoDbDSNDB.Record<umbracoRelationType>  
    {



		[Column] public int id { get; set; }





		[Column] public bool dual { get; set; }





		[Column] public Guid parentObjectType { get; set; }





		[Column] public Guid childObjectType { get; set; }





		[Column] public string name { get; set; }





		[Column] public string alias { get; set; }



	}

    
	[TableName("umbracoRelation")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class umbracoRelation : umbracoDbDSNDB.Record<umbracoRelation>  
    {



		[Column] public int id { get; set; }





		[Column] public int parentId { get; set; }





		[Column] public int childId { get; set; }





		[Column] public int relType { get; set; }





		[Column] public DateTime datetime { get; set; }





		[Column] public string comment { get; set; }



	}

    
	[TableName("cmsStylesheet")]


	[PrimaryKey("nodeId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsStylesheet : umbracoDbDSNDB.Record<cmsStylesheet>  
    {



		[Column] public int nodeId { get; set; }





		[Column] public string filename { get; set; }





		[Column] public string content { get; set; }



	}

    
	[TableName("cmsStylesheetProperty")]


	[PrimaryKey("nodeId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsStylesheetProperty : umbracoDbDSNDB.Record<cmsStylesheetProperty>  
    {



		[Column] public int nodeId { get; set; }





		[Column] public bool? stylesheetPropertyEditor { get; set; }





		[Column] public string stylesheetPropertyAlias { get; set; }





		[Column] public string stylesheetPropertyValue { get; set; }



	}

    
	[TableName("cmsTags")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsTag : umbracoDbDSNDB.Record<cmsTag>  
    {



		[Column] public int id { get; set; }





		[Column] public string tag { get; set; }





		[Column] public int? ParentId { get; set; }





		[Column] public string group { get; set; }



	}

    
	[TableName("cmsTagRelationship")]


	[PrimaryKey("nodeId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsTagRelationship : umbracoDbDSNDB.Record<cmsTagRelationship>  
    {



		[Column] public int nodeId { get; set; }





		[Column] public int tagId { get; set; }





		[Column] public int propertyTypeId { get; set; }



	}

    
	[TableName("umbracoUserLogins")]


	[ExplicitColumns]
    public partial class umbracoUserLogin : umbracoDbDSNDB.Record<umbracoUserLogin>  
    {



		[Column] public Guid contextID { get; set; }





		[Column] public int userID { get; set; }





		[Column] public long timeout { get; set; }



	}

    
	[TableName("umbracoUserType")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class umbracoUserType : umbracoDbDSNDB.Record<umbracoUserType>  
    {



		[Column] public int id { get; set; }





		[Column] public string userTypeAlias { get; set; }





		[Column] public string userTypeName { get; set; }





		[Column] public string userTypeDefaultPermissions { get; set; }



	}

    
	[TableName("umbracoUser")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class umbracoUser : umbracoDbDSNDB.Record<umbracoUser>  
    {



		[Column] public int id { get; set; }





		[Column] public bool userDisabled { get; set; }





		[Column] public bool userNoConsole { get; set; }





		[Column] public int userType { get; set; }





		[Column] public int startStructureID { get; set; }





		[Column] public int? startMediaID { get; set; }





		[Column] public string userName { get; set; }





		[Column] public string userLogin { get; set; }





		[Column] public string userPassword { get; set; }





		[Column] public string userEmail { get; set; }





		[Column] public string userLanguage { get; set; }



	}

    
	[TableName("cmsTaskType")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsTaskType : umbracoDbDSNDB.Record<cmsTaskType>  
    {



		[Column] public int id { get; set; }





		[Column] public string alias { get; set; }



	}

    
	[TableName("umbracoNode")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class umbracoNode : umbracoDbDSNDB.Record<umbracoNode>  
    {



		[Column] public int id { get; set; }





		[Column] public bool trashed { get; set; }





		[Column] public int parentID { get; set; }





		[Column] public int? nodeUser { get; set; }





		[Column] public int level { get; set; }





		[Column] public string path { get; set; }





		[Column] public int sortOrder { get; set; }





		[Column] public Guid? uniqueID { get; set; }





		[Column] public string text { get; set; }





		[Column] public Guid? nodeObjectType { get; set; }





		[Column] public DateTime createDate { get; set; }



	}

    
	[TableName("cmsTask")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsTask : umbracoDbDSNDB.Record<cmsTask>  
    {



		[Column] public bool closed { get; set; }





		[Column] public int id { get; set; }





		[Column] public int taskTypeId { get; set; }





		[Column] public int nodeId { get; set; }





		[Column] public int parentUserId { get; set; }





		[Column] public int userId { get; set; }





		[Column] public DateTime DateTime { get; set; }





		[Column] public string Comment { get; set; }



	}

    
	[TableName("cmsContentType")]


	[PrimaryKey("pk")]



	[ExplicitColumns]
    public partial class cmsContentType : umbracoDbDSNDB.Record<cmsContentType>  
    {



		[Column] public int pk { get; set; }





		[Column] public int nodeId { get; set; }





		[Column] public string alias { get; set; }





		[Column] public string icon { get; set; }





		[Column] public string thumbnail { get; set; }





		[Column] public string description { get; set; }





		[Column] public bool isContainer { get; set; }





		[Column] public bool allowAtRoot { get; set; }



	}

    
	[TableName("cmsContentType2ContentType")]


	[PrimaryKey("parentContentTypeId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsContentType2ContentType : umbracoDbDSNDB.Record<cmsContentType2ContentType>  
    {



		[Column] public int parentContentTypeId { get; set; }





		[Column] public int childContentTypeId { get; set; }



	}

    
	[TableName("cmsTemplate")]


	[PrimaryKey("pk")]



	[ExplicitColumns]
    public partial class cmsTemplate : umbracoDbDSNDB.Record<cmsTemplate>  
    {



		[Column] public int pk { get; set; }





		[Column] public int nodeId { get; set; }





		[Column] public int? master { get; set; }





		[Column] public string alias { get; set; }





		[Column] public string design { get; set; }



	}

    
	[TableName("cmsContentTypeAllowedContentType")]


	[PrimaryKey("Id", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsContentTypeAllowedContentType : umbracoDbDSNDB.Record<cmsContentTypeAllowedContentType>  
    {



		[Column] public int Id { get; set; }





		[Column] public int AllowedId { get; set; }





		[Column] public int SortOrder { get; set; }



	}

    
	[TableName("cmsContent")]


	[PrimaryKey("pk")]



	[ExplicitColumns]
    public partial class cmsContent : umbracoDbDSNDB.Record<cmsContent>  
    {



		[Column] public int pk { get; set; }





		[Column] public int nodeId { get; set; }





		[Column] public int contentType { get; set; }



	}

    
	[TableName("umbracoUser2app")]


	[PrimaryKey("user", autoIncrement=false)]

	[ExplicitColumns]
    public partial class umbracoUser2app : umbracoDbDSNDB.Record<umbracoUser2app>  
    {



		[Column] public int user { get; set; }





		[Column] public string app { get; set; }



	}

    
	[TableName("cmsContentVersion")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsContentVersion : umbracoDbDSNDB.Record<cmsContentVersion>  
    {



		[Column] public int id { get; set; }





		[Column] public int ContentId { get; set; }





		[Column] public Guid VersionId { get; set; }





		[Column] public DateTime VersionDate { get; set; }





		[Column] public string LanguageLocale { get; set; }



	}

    
	[TableName("umbracoUser2NodeNotify")]


	[PrimaryKey("userId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class umbracoUser2NodeNotify : umbracoDbDSNDB.Record<umbracoUser2NodeNotify>  
    {



		[Column] public int userId { get; set; }





		[Column] public int nodeId { get; set; }





		[Column] public string action { get; set; }



	}

    
	[TableName("cmsDocument")]


	[PrimaryKey("versionId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsDocument : umbracoDbDSNDB.Record<cmsDocument>  
    {



		[Column] public int nodeId { get; set; }





		[Column] public bool published { get; set; }





		[Column] public int documentUser { get; set; }





		[Column] public Guid versionId { get; set; }





		[Column] public string text { get; set; }





		[Column] public DateTime? releaseDate { get; set; }





		[Column] public DateTime? expireDate { get; set; }





		[Column] public DateTime updateDate { get; set; }





		[Column] public int? templateId { get; set; }





		[Column] public bool newest { get; set; }



	}

    
	[TableName("umbracoUser2NodePermission")]


	[PrimaryKey("userId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class umbracoUser2NodePermission : umbracoDbDSNDB.Record<umbracoUser2NodePermission>  
    {



		[Column] public int userId { get; set; }





		[Column] public int nodeId { get; set; }





		[Column] public string permission { get; set; }



	}

    
	[TableName("umbracoServer")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class umbracoServer : umbracoDbDSNDB.Record<umbracoServer>  
    {



		[Column] public int id { get; set; }





		[Column] public string address { get; set; }





		[Column] public string computerName { get; set; }





		[Column] public DateTime registeredDate { get; set; }





		[Column] public DateTime lastNotifiedDate { get; set; }





		[Column] public bool isActive { get; set; }



	}

    
	[TableName("cmsDocumentType")]


	[PrimaryKey("contentTypeNodeId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsDocumentType : umbracoDbDSNDB.Record<cmsDocumentType>  
    {



		[Column] public int contentTypeNodeId { get; set; }





		[Column] public int templateNodeId { get; set; }





		[Column] public bool IsDefault { get; set; }



	}

    
	[TableName("cmsDataType")]


	[PrimaryKey("pk")]



	[ExplicitColumns]
    public partial class cmsDataType : umbracoDbDSNDB.Record<cmsDataType>  
    {



		[Column] public int pk { get; set; }





		[Column] public int nodeId { get; set; }





		[Column] public string propertyEditorAlias { get; set; }





		[Column] public string dbType { get; set; }



	}

    
	[TableName("cmsDataTypePreValues")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsDataTypePreValue : umbracoDbDSNDB.Record<cmsDataTypePreValue>  
    {



		[Column] public int id { get; set; }





		[Column] public int datatypeNodeId { get; set; }





		[Column] public string value { get; set; }





		[Column] public int sortorder { get; set; }





		[Column] public string alias { get; set; }



	}

    
	[TableName("cmsDictionary")]


	[PrimaryKey("pk")]



	[ExplicitColumns]
    public partial class cmsDictionary : umbracoDbDSNDB.Record<cmsDictionary>  
    {



		[Column] public int pk { get; set; }





		[Column] public Guid id { get; set; }





		[Column] public Guid parent { get; set; }





		[Column] public string key { get; set; }



	}

    
	[TableName("cmsLanguageText")]


	[PrimaryKey("pk")]



	[ExplicitColumns]
    public partial class cmsLanguageText : umbracoDbDSNDB.Record<cmsLanguageText>  
    {



		[Column] public int pk { get; set; }





		[Column] public int languageId { get; set; }





		[Column] public Guid UniqueId { get; set; }





		[Column] public string value { get; set; }



	}

    
	[TableName("umbracoLanguage")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class umbracoLanguage : umbracoDbDSNDB.Record<umbracoLanguage>  
    {



		[Column] public int id { get; set; }





		[Column] public string languageISOCode { get; set; }





		[Column] public string languageCultureName { get; set; }



	}

    
	[TableName("umbracoDomains")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class umbracoDomain : umbracoDbDSNDB.Record<umbracoDomain>  
    {



		[Column] public int id { get; set; }





		[Column] public int? domainDefaultLanguage { get; set; }





		[Column] public int? domainRootStructureID { get; set; }





		[Column] public string domainName { get; set; }



	}

    
	[TableName("TimetableNode")]


	[PrimaryKey("Id")]



	[ExplicitColumns]
    public partial class TimetableNode : umbracoDbDSNDB.Record<TimetableNode>  
    {



		[Column] public int Id { get; set; }





		[Column] public int StationId { get; set; }





		[Column] public int ServiceId { get; set; }





		[Column] public DateTime Time { get; set; }



	}

    
	[TableName("umbracoLog")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class umbracoLog : umbracoDbDSNDB.Record<umbracoLog>  
    {



		[Column] public int id { get; set; }





		[Column] public int userId { get; set; }





		[Column] public int NodeId { get; set; }





		[Column] public DateTime Datestamp { get; set; }





		[Column] public string logHeader { get; set; }





		[Column] public string logComment { get; set; }



	}

    
	[TableName("DatabaseTimetableModel")]


	[PrimaryKey("Id")]



	[ExplicitColumns]
    public partial class DatabaseTimetableModel : umbracoDbDSNDB.Record<DatabaseTimetableModel>  
    {



		[Column] public int Id { get; set; }





		[Column] public int StationId { get; set; }





		[Column] public int ServiceId { get; set; }





		[Column] public string Time { get; set; }



	}

    
	[TableName("cmsMacro")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsMacro : umbracoDbDSNDB.Record<cmsMacro>  
    {



		[Column] public int id { get; set; }





		[Column] public bool macroUseInEditor { get; set; }





		[Column] public int macroRefreshRate { get; set; }





		[Column] public string macroAlias { get; set; }





		[Column] public string macroName { get; set; }





		[Column] public string macroScriptType { get; set; }





		[Column] public string macroScriptAssembly { get; set; }





		[Column] public string macroXSLT { get; set; }





		[Column] public bool macroCacheByPage { get; set; }





		[Column] public bool macroCachePersonalized { get; set; }





		[Column] public bool macroDontRender { get; set; }





		[Column] public string macroPython { get; set; }



	}

    
	[TableName("cmsMacroProperty")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsMacroProperty : umbracoDbDSNDB.Record<cmsMacroProperty>  
    {



		[Column] public int id { get; set; }





		[Column] public string editorAlias { get; set; }





		[Column] public int macro { get; set; }





		[Column] public int macroPropertySortOrder { get; set; }





		[Column] public string macroPropertyAlias { get; set; }





		[Column] public string macroPropertyName { get; set; }



	}

    
	[TableName("cmsMemberType")]


	[PrimaryKey("pk")]



	[ExplicitColumns]
    public partial class cmsMemberType : umbracoDbDSNDB.Record<cmsMemberType>  
    {



		[Column] public int pk { get; set; }





		[Column] public int NodeId { get; set; }





		[Column] public int propertytypeId { get; set; }





		[Column] public bool memberCanEdit { get; set; }





		[Column] public bool viewOnProfile { get; set; }



	}

    
	[TableName("cmsMember")]


	[PrimaryKey("nodeId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsMember : umbracoDbDSNDB.Record<cmsMember>  
    {



		[Column] public int nodeId { get; set; }





		[Column] public string Email { get; set; }





		[Column] public string LoginName { get; set; }





		[Column] public string Password { get; set; }



	}

    
	[TableName("cmsMember2MemberGroup")]


	[PrimaryKey("Member", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsMember2MemberGroup : umbracoDbDSNDB.Record<cmsMember2MemberGroup>  
    {



		[Column] public int Member { get; set; }





		[Column] public int MemberGroup { get; set; }



	}

    
	[TableName("cmsContentXml")]


	[PrimaryKey("nodeId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsContentXml : umbracoDbDSNDB.Record<cmsContentXml>  
    {



		[Column] public int nodeId { get; set; }





		[Column] public string xml { get; set; }



	}

    
	[TableName("cmsPreviewXml")]


	[PrimaryKey("nodeId", autoIncrement=false)]

	[ExplicitColumns]
    public partial class cmsPreviewXml : umbracoDbDSNDB.Record<cmsPreviewXml>  
    {



		[Column] public int nodeId { get; set; }





		[Column] public Guid versionId { get; set; }





		[Column] public DateTime timestamp { get; set; }





		[Column] public string xml { get; set; }



	}

    
	[TableName("cmsPropertyTypeGroup")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsPropertyTypeGroup : umbracoDbDSNDB.Record<cmsPropertyTypeGroup>  
    {



		[Column] public int id { get; set; }





		[Column] public int? parentGroupId { get; set; }





		[Column] public int contenttypeNodeId { get; set; }





		[Column] public string text { get; set; }





		[Column] public int sortorder { get; set; }



	}

    
	[TableName("cmsPropertyType")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cmsPropertyType : umbracoDbDSNDB.Record<cmsPropertyType>  
    {



		[Column] public int id { get; set; }





		[Column] public int dataTypeId { get; set; }





		[Column] public int contentTypeId { get; set; }





		[Column] public int? propertyTypeGroupId { get; set; }





		[Column] public string Alias { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string helpText { get; set; }





		[Column] public int sortOrder { get; set; }





		[Column] public bool mandatory { get; set; }





		[Column] public string validationRegExp { get; set; }





		[Column] public string Description { get; set; }



	}


}



