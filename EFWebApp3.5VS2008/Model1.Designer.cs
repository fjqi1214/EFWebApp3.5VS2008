﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.6400
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 3/11/2013 1:19:40 PM
namespace EFWebApp3._5VS2008to2010
{
    
    /// <summary>
    /// There are no comments for Model1Container in the schema.
    /// </summary>
    public partial class Model1Container : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new Model1Container object using the connection string found in the 'Model1Container' section of the application configuration file.
        /// </summary>
        public Model1Container() : 
                base("name=Model1Container", "Model1Container")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(string connectionString) : 
                base(connectionString, "Model1Container")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "Model1Container")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for MusicGenres in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<MusicGenres> MusicGenres
        {
            get
            {
                if ((this._MusicGenres == null))
                {
                    this._MusicGenres = base.CreateQuery<MusicGenres>("[MusicGenres]");
                }
                return this._MusicGenres;
            }
        }
        private global::System.Data.Objects.ObjectQuery<MusicGenres> _MusicGenres;
        /// <summary>
        /// There are no comments for MusicGenres in the schema.
        /// </summary>
        public void AddToMusicGenres(MusicGenres musicGenres)
        {
            base.AddObject("MusicGenres", musicGenres);
        }
    }
    /// <summary>
    /// There are no comments for Model1.MusicGenres in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// GenreName
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="Model1", Name="MusicGenres")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class MusicGenres : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new MusicGenres object.
        /// </summary>
        /// <param name="id">Initial value of ID.</param>
        /// <param name="genreName">Initial value of GenreName.</param>
        public static MusicGenres CreateMusicGenres(int id, string genreName)
        {
            MusicGenres musicGenres = new MusicGenres();
            musicGenres.ID = id;
            musicGenres.GenreName = genreName;
            return musicGenres;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this.ReportPropertyChanging("ID");
                this._ID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ID");
                this.OnIDChanged();
            }
        }
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property GenreName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string GenreName
        {
            get
            {
                return this._GenreName;
            }
            set
            {
                this.OnGenreNameChanging(value);
                this.ReportPropertyChanging("GenreName");
                this._GenreName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("GenreName");
                this.OnGenreNameChanged();
            }
        }
        private string _GenreName;
        partial void OnGenreNameChanging(string value);
        partial void OnGenreNameChanged();
    }
}
