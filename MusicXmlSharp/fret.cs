using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class fret : INotifyPropertyChanged
	{

		private string fontfamilyField;

		private fontstyle fontstyleField;

		private bool fontstyleFieldSpecified;

		private string fontsizeField;

		private fontweight fontweightField;

		private bool fontweightFieldSpecified;

		private string colorField;

		private string valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
		public string fontfamily
		{
			get
			{
				return this.fontfamilyField;
			}
			set
			{
				this.fontfamilyField = value;
				this.RaisePropertyChanged("fontfamily");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("font-style")]
		public fontstyle fontstyle
		{
			get
			{
				return this.fontstyleField;
			}
			set
			{
				this.fontstyleField = value;
				this.RaisePropertyChanged("fontstyle");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool fontstyleSpecified
		{
			get
			{
				return this.fontstyleFieldSpecified;
			}
			set
			{
				this.fontstyleFieldSpecified = value;
				this.RaisePropertyChanged("fontstyleSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("font-size")]
		public string fontsize
		{
			get
			{
				return this.fontsizeField;
			}
			set
			{
				this.fontsizeField = value;
				this.RaisePropertyChanged("fontsize");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
		public fontweight fontweight
		{
			get
			{
				return this.fontweightField;
			}
			set
			{
				this.fontweightField = value;
				this.RaisePropertyChanged("fontweight");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool fontweightSpecified
		{
			get
			{
				return this.fontweightFieldSpecified;
			}
			set
			{
				this.fontweightFieldSpecified = value;
				this.RaisePropertyChanged("fontweightSpecified");
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

		/// <remarks />
		[System.Xml.Serialization.XmlTextAttribute(DataType = "nonNegativeInteger")]
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
