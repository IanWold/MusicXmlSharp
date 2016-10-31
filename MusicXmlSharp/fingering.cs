using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class fingering : INotifyPropertyChanged
	{

		private yesno substitutionField;

		private bool substitutionFieldSpecified;

		private yesno alternateField;

		private bool alternateFieldSpecified;

		private abovebelow placementField;

		private bool placementFieldSpecified;

		private string valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno substitution
		{
			get
			{
				return this.substitutionField;
			}
			set
			{
				this.substitutionField = value;
				this.RaisePropertyChanged("substitution");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool substitutionSpecified
		{
			get
			{
				return this.substitutionFieldSpecified;
			}
			set
			{
				this.substitutionFieldSpecified = value;
				this.RaisePropertyChanged("substitutionSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno alternate
		{
			get
			{
				return this.alternateField;
			}
			set
			{
				this.alternateField = value;
				this.RaisePropertyChanged("alternate");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool alternateSpecified
		{
			get
			{
				return this.alternateFieldSpecified;
			}
			set
			{
				this.alternateFieldSpecified = value;
				this.RaisePropertyChanged("alternateSpecified");
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
