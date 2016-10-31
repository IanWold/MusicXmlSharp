using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class level : INotifyPropertyChanged
	{

		private yesno referenceField;

		private bool referenceFieldSpecified;

		private yesno parenthesesField;

		private bool parenthesesFieldSpecified;

		private yesno bracketField;

		private bool bracketFieldSpecified;

		private symbolsize sizeField;

		private bool sizeFieldSpecified;

		private string valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno reference
		{
			get
			{
				return this.referenceField;
			}
			set
			{
				this.referenceField = value;
				this.RaisePropertyChanged("reference");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool referenceSpecified
		{
			get
			{
				return this.referenceFieldSpecified;
			}
			set
			{
				this.referenceFieldSpecified = value;
				this.RaisePropertyChanged("referenceSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno parentheses
		{
			get
			{
				return this.parenthesesField;
			}
			set
			{
				this.parenthesesField = value;
				this.RaisePropertyChanged("parentheses");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool parenthesesSpecified
		{
			get
			{
				return this.parenthesesFieldSpecified;
			}
			set
			{
				this.parenthesesFieldSpecified = value;
				this.RaisePropertyChanged("parenthesesSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno bracket
		{
			get
			{
				return this.bracketField;
			}
			set
			{
				this.bracketField = value;
				this.RaisePropertyChanged("bracket");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool bracketSpecified
		{
			get
			{
				return this.bracketFieldSpecified;
			}
			set
			{
				this.bracketFieldSpecified = value;
				this.RaisePropertyChanged("bracketSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public symbolsize size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
				this.RaisePropertyChanged("size");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool sizeSpecified
		{
			get
			{
				return this.sizeFieldSpecified;
			}
			set
			{
				this.sizeFieldSpecified = value;
				this.RaisePropertyChanged("sizeSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
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
