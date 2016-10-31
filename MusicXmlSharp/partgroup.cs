using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-group")]
	public partial class partgroup : INotifyPropertyChanged
	{

		private groupname groupnameField;

		private namedisplay groupnamedisplayField;

		private groupname groupabbreviationField;

		private namedisplay groupabbreviationdisplayField;

		private groupsymbol groupsymbolField;

		private groupbarline groupbarlineField;

		private empty grouptimeField;

		private formattedtext footnoteField;

		private level levelField;

		private startstop typeField;

		private string numberField;

		public partgroup()
		{
			this.numberField = "1";
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("group-name")]
		public groupname groupname
		{
			get
			{
				return this.groupnameField;
			}
			set
			{
				this.groupnameField = value;
				this.RaisePropertyChanged("groupname");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("group-name-display")]
		public namedisplay groupnamedisplay
		{
			get
			{
				return this.groupnamedisplayField;
			}
			set
			{
				this.groupnamedisplayField = value;
				this.RaisePropertyChanged("groupnamedisplay");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("group-abbreviation")]
		public groupname groupabbreviation
		{
			get
			{
				return this.groupabbreviationField;
			}
			set
			{
				this.groupabbreviationField = value;
				this.RaisePropertyChanged("groupabbreviation");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("group-abbreviation-display")]
		public namedisplay groupabbreviationdisplay
		{
			get
			{
				return this.groupabbreviationdisplayField;
			}
			set
			{
				this.groupabbreviationdisplayField = value;
				this.RaisePropertyChanged("groupabbreviationdisplay");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("group-symbol")]
		public groupsymbol groupsymbol
		{
			get
			{
				return this.groupsymbolField;
			}
			set
			{
				this.groupsymbolField = value;
				this.RaisePropertyChanged("groupsymbol");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("group-barline")]
		public groupbarline groupbarline
		{
			get
			{
				return this.groupbarlineField;
			}
			set
			{
				this.groupbarlineField = value;
				this.RaisePropertyChanged("groupbarline");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("group-time")]
		public empty grouptime
		{
			get
			{
				return this.grouptimeField;
			}
			set
			{
				this.grouptimeField = value;
				this.RaisePropertyChanged("grouptime");
			}
		}

		/// <remarks />
		public formattedtext footnote
		{
			get
			{
				return this.footnoteField;
			}
			set
			{
				this.footnoteField = value;
				this.RaisePropertyChanged("footnote");
			}
		}

		/// <remarks />
		public level level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
				this.RaisePropertyChanged("level");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public startstop type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("type");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
		[DefaultValueAttribute("1")]
		public string number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.numberField = value;
				this.RaisePropertyChanged("number");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}

}
