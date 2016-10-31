using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class link : INotifyPropertyChanged
	{

		private string hrefField;

		private opuslinkType typeField;

		private bool typeFieldSpecified;

		private string roleField;

		private string titleField;

		private opuslinkShow showField;

		private opuslinkActuate actuateField;

		private string nameField;

		private string elementField;

		private string positionField;

		private decimal defaultxField;

		private bool defaultxFieldSpecified;

		private decimal defaultyField;

		private bool defaultyFieldSpecified;

		private decimal relativexField;

		private bool relativexFieldSpecified;

		private decimal relativeyField;

		private bool relativeyFieldSpecified;

		public link()
		{
			this.typeField = opuslinkType.simple;
			this.showField = opuslinkShow.replace;
			this.actuateField = opuslinkActuate.onRequest;
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
		public string href
		{
			get
			{
				return this.hrefField;
			}
			set
			{
				this.hrefField = value;
				this.RaisePropertyChanged("href");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
		public opuslinkType type
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
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
				this.RaisePropertyChanged("typeSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "token")]
		public string role
		{
			get
			{
				return this.roleField;
			}
			set
			{
				this.roleField = value;
				this.RaisePropertyChanged("role");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "token")]
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("title");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
		[DefaultValueAttribute(opuslinkShow.replace)]
		public opuslinkShow show
		{
			get
			{
				return this.showField;
			}
			set
			{
				this.showField = value;
				this.RaisePropertyChanged("show");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
		[DefaultValueAttribute(opuslinkActuate.onRequest)]
		public opuslinkActuate actuate
		{
			get
			{
				return this.actuateField;
			}
			set
			{
				this.actuateField = value;
				this.RaisePropertyChanged("actuate");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("name");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
		public string element
		{
			get
			{
				return this.elementField;
			}
			set
			{
				this.elementField = value;
				this.RaisePropertyChanged("element");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
		public string position
		{
			get
			{
				return this.positionField;
			}
			set
			{
				this.positionField = value;
				this.RaisePropertyChanged("position");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("default-x")]
		public decimal defaultx
		{
			get
			{
				return this.defaultxField;
			}
			set
			{
				this.defaultxField = value;
				this.RaisePropertyChanged("defaultx");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool defaultxSpecified
		{
			get
			{
				return this.defaultxFieldSpecified;
			}
			set
			{
				this.defaultxFieldSpecified = value;
				this.RaisePropertyChanged("defaultxSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("default-y")]
		public decimal defaulty
		{
			get
			{
				return this.defaultyField;
			}
			set
			{
				this.defaultyField = value;
				this.RaisePropertyChanged("defaulty");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool defaultySpecified
		{
			get
			{
				return this.defaultyFieldSpecified;
			}
			set
			{
				this.defaultyFieldSpecified = value;
				this.RaisePropertyChanged("defaultySpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
		public decimal relativex
		{
			get
			{
				return this.relativexField;
			}
			set
			{
				this.relativexField = value;
				this.RaisePropertyChanged("relativex");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool relativexSpecified
		{
			get
			{
				return this.relativexFieldSpecified;
			}
			set
			{
				this.relativexFieldSpecified = value;
				this.RaisePropertyChanged("relativexSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
		public decimal relativey
		{
			get
			{
				return this.relativeyField;
			}
			set
			{
				this.relativeyField = value;
				this.RaisePropertyChanged("relativey");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool relativeySpecified
		{
			get
			{
				return this.relativeyFieldSpecified;
			}
			set
			{
				this.relativeyFieldSpecified = value;
				this.RaisePropertyChanged("relativeySpecified");
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
