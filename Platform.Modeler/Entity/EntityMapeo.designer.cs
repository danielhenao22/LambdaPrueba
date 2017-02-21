﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Platform.Modeler.Entity
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ejemploConexionBD")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertestudiante(estudiante instance);
    partial void Updateestudiante(estudiante instance);
    partial void Deleteestudiante(estudiante instance);
    partial void Insertpagos(pagos instance);
    partial void Updatepagos(pagos instance);
    partial void Deletepagos(pagos instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Platform.Modeler.Properties.Settings.Default.ejemploConexionBDConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<estudiante> estudiante
		{
			get
			{
				return this.GetTable<estudiante>();
			}
		}
		
		public System.Data.Linq.Table<pagos> pagos
		{
			get
			{
				return this.GetTable<pagos>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.estudiante")]
	public partial class estudiante : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _codigo;
		
		private string _nombre;
		
		private string _apellido;
		
		private System.Nullable<int> _edad;
		
		private string _carrera;
		
		private string _semestre;
		
		private EntitySet<pagos> _pagos;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodigoChanging(string value);
    partial void OncodigoChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoChanging(string value);
    partial void OnapellidoChanged();
    partial void OnedadChanging(System.Nullable<int> value);
    partial void OnedadChanged();
    partial void OncarreraChanging(string value);
    partial void OncarreraChanged();
    partial void OnsemestreChanging(string value);
    partial void OnsemestreChanged();
    #endregion
		
		public estudiante()
		{
			this._pagos = new EntitySet<pagos>(new Action<pagos>(this.attach_pagos), new Action<pagos>(this.detach_pagos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(20)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido", DbType="NVarChar(20)")]
		public string apellido
		{
			get
			{
				return this._apellido;
			}
			set
			{
				if ((this._apellido != value))
				{
					this.OnapellidoChanging(value);
					this.SendPropertyChanging();
					this._apellido = value;
					this.SendPropertyChanged("apellido");
					this.OnapellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_edad", DbType="Int")]
		public System.Nullable<int> edad
		{
			get
			{
				return this._edad;
			}
			set
			{
				if ((this._edad != value))
				{
					this.OnedadChanging(value);
					this.SendPropertyChanging();
					this._edad = value;
					this.SendPropertyChanged("edad");
					this.OnedadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carrera", DbType="NVarChar(20)")]
		public string carrera
		{
			get
			{
				return this._carrera;
			}
			set
			{
				if ((this._carrera != value))
				{
					this.OncarreraChanging(value);
					this.SendPropertyChanging();
					this._carrera = value;
					this.SendPropertyChanged("carrera");
					this.OncarreraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_semestre", DbType="NVarChar(20)")]
		public string semestre
		{
			get
			{
				return this._semestre;
			}
			set
			{
				if ((this._semestre != value))
				{
					this.OnsemestreChanging(value);
					this.SendPropertyChanging();
					this._semestre = value;
					this.SendPropertyChanged("semestre");
					this.OnsemestreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="estudiante_pagos", Storage="_pagos", ThisKey="codigo", OtherKey="codigo_estudiante")]
		public EntitySet<pagos> pagos
		{
			get
			{
				return this._pagos;
			}
			set
			{
				this._pagos.Assign(value);
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
		
		private void attach_pagos(pagos entity)
		{
			this.SendPropertyChanging();
			entity.estudiante = this;
		}
		
		private void detach_pagos(pagos entity)
		{
			this.SendPropertyChanging();
			entity.estudiante = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pagos")]
	public partial class pagos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _codigo;
		
		private System.Nullable<double> _monto;
		
		private string _descripcion;
		
		private string _codigo_estudiante;
		
		private EntityRef<estudiante> _estudiante;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OncodigoChanging(string value);
    partial void OncodigoChanged();
    partial void OnmontoChanging(System.Nullable<double> value);
    partial void OnmontoChanged();
    partial void OndescripcionChanging(string value);
    partial void OndescripcionChanged();
    partial void Oncodigo_estudianteChanging(string value);
    partial void Oncodigo_estudianteChanged();
    #endregion
		
		public pagos()
		{
			this._estudiante = default(EntityRef<estudiante>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", DbType="NVarChar(30)")]
		public string codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_monto", DbType="Float")]
		public System.Nullable<double> monto
		{
			get
			{
				return this._monto;
			}
			set
			{
				if ((this._monto != value))
				{
					this.OnmontoChanging(value);
					this.SendPropertyChanging();
					this._monto = value;
					this.SendPropertyChanged("monto");
					this.OnmontoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="NVarChar(20)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this.OndescripcionChanging(value);
					this.SendPropertyChanging();
					this._descripcion = value;
					this.SendPropertyChanged("descripcion");
					this.OndescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo_estudiante", DbType="NVarChar(20)")]
		public string codigo_estudiante
		{
			get
			{
				return this._codigo_estudiante;
			}
			set
			{
				if ((this._codigo_estudiante != value))
				{
					if (this._estudiante.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncodigo_estudianteChanging(value);
					this.SendPropertyChanging();
					this._codigo_estudiante = value;
					this.SendPropertyChanged("codigo_estudiante");
					this.Oncodigo_estudianteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="estudiante_pagos", Storage="_estudiante", ThisKey="codigo_estudiante", OtherKey="codigo", IsForeignKey=true)]
		public estudiante estudiante
		{
			get
			{
				return this._estudiante.Entity;
			}
			set
			{
				estudiante previousValue = this._estudiante.Entity;
				if (((previousValue != value) 
							|| (this._estudiante.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._estudiante.Entity = null;
						previousValue.pagos.Remove(this);
					}
					this._estudiante.Entity = value;
					if ((value != null))
					{
						value.pagos.Add(this);
						this._codigo_estudiante = value.codigo;
					}
					else
					{
						this._codigo_estudiante = default(string);
					}
					this.SendPropertyChanged("estudiante");
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