#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IT_Final_Year_Lohaghat.LinqToSQL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ITFinalYear")]
	public partial class ITFinalYearClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public ITFinalYearClassDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ITFinalYearConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ITFinalYearClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ITFinalYearClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ITFinalYearClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ITFinalYearClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _UserLoginID;
		
		private string _UserFirstName;
		
		private string _UserLastName;
		
		private byte _UserSecurityQuestion;
		
		private string _UserSecurityAnswer;
		
		private string _UserLoginPassword;
		
		private byte _UserIsActive;
		
		private System.DateTime _UserCreatedOn;
		
		private System.DateTime _UserUpdatedOn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUserLoginIDChanging(string value);
    partial void OnUserLoginIDChanged();
    partial void OnUserFirstNameChanging(string value);
    partial void OnUserFirstNameChanged();
    partial void OnUserLastNameChanging(string value);
    partial void OnUserLastNameChanged();
    partial void OnUserSecurityQuestionChanging(byte value);
    partial void OnUserSecurityQuestionChanged();
    partial void OnUserSecurityAnswerChanging(string value);
    partial void OnUserSecurityAnswerChanged();
    partial void OnUserLoginPasswordChanging(string value);
    partial void OnUserLoginPasswordChanged();
    partial void OnUserIsActiveChanging(byte value);
    partial void OnUserIsActiveChanged();
    partial void OnUserCreatedOnChanging(System.DateTime value);
    partial void OnUserCreatedOnChanged();
    partial void OnUserUpdatedOnChanging(System.DateTime value);
    partial void OnUserUpdatedOnChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserLoginID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserLoginID
		{
			get
			{
				return this._UserLoginID;
			}
			set
			{
				if ((this._UserLoginID != value))
				{
					this.OnUserLoginIDChanging(value);
					this.SendPropertyChanging();
					this._UserLoginID = value;
					this.SendPropertyChanged("UserLoginID");
					this.OnUserLoginIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserFirstName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string UserFirstName
		{
			get
			{
				return this._UserFirstName;
			}
			set
			{
				if ((this._UserFirstName != value))
				{
					this.OnUserFirstNameChanging(value);
					this.SendPropertyChanging();
					this._UserFirstName = value;
					this.SendPropertyChanged("UserFirstName");
					this.OnUserFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserLastName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string UserLastName
		{
			get
			{
				return this._UserLastName;
			}
			set
			{
				if ((this._UserLastName != value))
				{
					this.OnUserLastNameChanging(value);
					this.SendPropertyChanging();
					this._UserLastName = value;
					this.SendPropertyChanged("UserLastName");
					this.OnUserLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserSecurityQuestion", DbType="TinyInt NOT NULL")]
		public byte UserSecurityQuestion
		{
			get
			{
				return this._UserSecurityQuestion;
			}
			set
			{
				if ((this._UserSecurityQuestion != value))
				{
					this.OnUserSecurityQuestionChanging(value);
					this.SendPropertyChanging();
					this._UserSecurityQuestion = value;
					this.SendPropertyChanged("UserSecurityQuestion");
					this.OnUserSecurityQuestionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserSecurityAnswer", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserSecurityAnswer
		{
			get
			{
				return this._UserSecurityAnswer;
			}
			set
			{
				if ((this._UserSecurityAnswer != value))
				{
					this.OnUserSecurityAnswerChanging(value);
					this.SendPropertyChanging();
					this._UserSecurityAnswer = value;
					this.SendPropertyChanged("UserSecurityAnswer");
					this.OnUserSecurityAnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserLoginPassword", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserLoginPassword
		{
			get
			{
				return this._UserLoginPassword;
			}
			set
			{
				if ((this._UserLoginPassword != value))
				{
					this.OnUserLoginPasswordChanging(value);
					this.SendPropertyChanging();
					this._UserLoginPassword = value;
					this.SendPropertyChanged("UserLoginPassword");
					this.OnUserLoginPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserIsActive", DbType="TinyInt NOT NULL")]
		public byte UserIsActive
		{
			get
			{
				return this._UserIsActive;
			}
			set
			{
				if ((this._UserIsActive != value))
				{
					this.OnUserIsActiveChanging(value);
					this.SendPropertyChanging();
					this._UserIsActive = value;
					this.SendPropertyChanged("UserIsActive");
					this.OnUserIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCreatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime UserCreatedOn
		{
			get
			{
				return this._UserCreatedOn;
			}
			set
			{
				if ((this._UserCreatedOn != value))
				{
					this.OnUserCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._UserCreatedOn = value;
					this.SendPropertyChanged("UserCreatedOn");
					this.OnUserCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserUpdatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime UserUpdatedOn
		{
			get
			{
				return this._UserUpdatedOn;
			}
			set
			{
				if ((this._UserUpdatedOn != value))
				{
					this.OnUserUpdatedOnChanging(value);
					this.SendPropertyChanging();
					this._UserUpdatedOn = value;
					this.SendPropertyChanged("UserUpdatedOn");
					this.OnUserUpdatedOnChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
