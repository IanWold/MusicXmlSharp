using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class beam : INotifyPropertyChanged
	{

		private string numberField;

		private yesno repeaterField;

		private bool repeaterFieldSpecified;

		private fan fanField;

		private bool fanFieldSpecified;

		private string colorField;

		private beamvalue valueField;

		public beam()
		{
			this.numberField = "1";
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno repeater
		{
			get
			{
				return this.repeaterField;
			}
			set
			{
				this.repeaterField = value;
				this.RaisePropertyChanged("repeater");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool repeaterSpecified
		{
			get
			{
				return this.repeaterFieldSpecified;
			}
			set
			{
				this.repeaterFieldSpecified = value;
				this.RaisePropertyChanged("repeaterSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public fan fan
		{
			get
			{
				return this.fanField;
			}
			set
			{
				this.fanField = value;
				this.RaisePropertyChanged("fan");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool fanSpecified
		{
			get
			{
				return this.fanFieldSpecified;
			}
			set
			{
				this.fanFieldSpecified = value;
				this.RaisePropertyChanged("fanSpecified");
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
		[System.Xml.Serialization.XmlTextAttribute()]
		public beamvalue Value
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
