using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "octave-shift")]
	public partial class octaveshift : INotifyPropertyChanged
	{

		private updownstopcontinue typeField;

		private string numberField;

		private string sizeField;

		private decimal dashlengthField;

		private bool dashlengthFieldSpecified;

		private decimal spacelengthField;

		private bool spacelengthFieldSpecified;

		public octaveshift()
		{
			this.sizeField = "8";
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public updownstopcontinue type
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
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
		[DefaultValueAttribute("8")]
		public string size
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
		[System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
		public decimal dashlength
		{
			get
			{
				return this.dashlengthField;
			}
			set
			{
				this.dashlengthField = value;
				this.RaisePropertyChanged("dashlength");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool dashlengthSpecified
		{
			get
			{
				return this.dashlengthFieldSpecified;
			}
			set
			{
				this.dashlengthFieldSpecified = value;
				this.RaisePropertyChanged("dashlengthSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("space-length")]
		public decimal spacelength
		{
			get
			{
				return this.spacelengthField;
			}
			set
			{
				this.spacelengthField = value;
				this.RaisePropertyChanged("spacelength");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool spacelengthSpecified
		{
			get
			{
				return this.spacelengthFieldSpecified;
			}
			set
			{
				this.spacelengthFieldSpecified = value;
				this.RaisePropertyChanged("spacelengthSpecified");
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
