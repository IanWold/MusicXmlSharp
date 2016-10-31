using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class score : INotifyPropertyChanged
	{

		private string hrefField;

		private opuslinkType typeField;

		private bool typeFieldSpecified;

		private string roleField;

		private string titleField;

		private opuslinkShow showField;

		private opuslinkActuate actuateField;

		private yesno newpageField;

		private bool newpageFieldSpecified;

		public score()
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
		[System.Xml.Serialization.XmlAttributeAttribute("new-page")]
		public yesno newpage
		{
			get
			{
				return this.newpageField;
			}
			set
			{
				this.newpageField = value;
				this.RaisePropertyChanged("newpage");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool newpageSpecified
		{
			get
			{
				return this.newpageFieldSpecified;
			}
			set
			{
				this.newpageFieldSpecified = value;
				this.RaisePropertyChanged("newpageSpecified");
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
