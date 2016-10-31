using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "non-arpeggiate")]
	public partial class nonarpeggiate : INotifyPropertyChanged
	{

		private topbottom typeField;

		private string numberField;

		private decimal defaultxField;

		private bool defaultxFieldSpecified;

		private decimal defaultyField;

		private bool defaultyFieldSpecified;

		private decimal relativexField;

		private bool relativexFieldSpecified;

		private decimal relativeyField;

		private bool relativeyFieldSpecified;

		private abovebelow placementField;

		private bool placementFieldSpecified;

		private string colorField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public topbottom type
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
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
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

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public abovebelow placement
		{
			get
			{
				return this.placementField;
			}
			set
			{
				this.placementField = value;
				this.RaisePropertyChanged("placement");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool placementSpecified
		{
			get
			{
				return this.placementFieldSpecified;
			}
			set
			{
				this.placementFieldSpecified = value;
				this.RaisePropertyChanged("placementSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
		public string color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
				this.RaisePropertyChanged("color");
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
