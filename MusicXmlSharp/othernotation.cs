using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "other-notation")]
	public partial class othernotation : INotifyPropertyChanged
	{

		private startstopsingle typeField;

		private string numberField;

		private yesno printobjectField;

		private bool printobjectFieldSpecified;

		private abovebelow placementField;

		private bool placementFieldSpecified;

		private string valueField;

		public othernotation()
		{
			this.numberField = "1";
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public startstopsingle type
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

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("print-object")]
		public yesno printobject
		{
			get
			{
				return this.printobjectField;
			}
			set
			{
				this.printobjectField = value;
				this.RaisePropertyChanged("printobject");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool printobjectSpecified
		{
			get
			{
				return this.printobjectFieldSpecified;
			}
			set
			{
				this.printobjectFieldSpecified = value;
				this.RaisePropertyChanged("printobjectSpecified");
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
