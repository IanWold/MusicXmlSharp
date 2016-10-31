using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class interchangeable : INotifyPropertyChanged
	{

		private timerelation timerelationField;

		private bool timerelationFieldSpecified;

		private string[] beatsField;

		private string[] beattypeField;

		private timesymbol symbolField;

		private bool symbolFieldSpecified;

		private timeseparator separatorField;

		private bool separatorFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("time-relation")]
		public timerelation timerelation
		{
			get
			{
				return this.timerelationField;
			}
			set
			{
				this.timerelationField = value;
				this.RaisePropertyChanged("timerelation");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool timerelationSpecified
		{
			get
			{
				return this.timerelationFieldSpecified;
			}
			set
			{
				this.timerelationFieldSpecified = value;
				this.RaisePropertyChanged("timerelationSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("beats")]
		public string[] beats
		{
			get
			{
				return this.beatsField;
			}
			set
			{
				this.beatsField = value;
				this.RaisePropertyChanged("beats");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("beat-type")]
		public string[] beattype
		{
			get
			{
				return this.beattypeField;
			}
			set
			{
				this.beattypeField = value;
				this.RaisePropertyChanged("beattype");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public timesymbol symbol
		{
			get
			{
				return this.symbolField;
			}
			set
			{
				this.symbolField = value;
				this.RaisePropertyChanged("symbol");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool symbolSpecified
		{
			get
			{
				return this.symbolFieldSpecified;
			}
			set
			{
				this.symbolFieldSpecified = value;
				this.RaisePropertyChanged("symbolSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public timeseparator separator
		{
			get
			{
				return this.separatorField;
			}
			set
			{
				this.separatorField = value;
				this.RaisePropertyChanged("separator");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool separatorSpecified
		{
			get
			{
				return this.separatorFieldSpecified;
			}
			set
			{
				this.separatorFieldSpecified = value;
				this.RaisePropertyChanged("separatorSpecified");
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
