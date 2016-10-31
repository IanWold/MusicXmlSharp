using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class pedal : INotifyPropertyChanged
	{

		private startstopchangecontinue typeField;

		private yesno lineField;

		private bool lineFieldSpecified;

		private yesno signField;

		private bool signFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public startstopchangecontinue type
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno line
		{
			get
			{
				return this.lineField;
			}
			set
			{
				this.lineField = value;
				this.RaisePropertyChanged("line");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool lineSpecified
		{
			get
			{
				return this.lineFieldSpecified;
			}
			set
			{
				this.lineFieldSpecified = value;
				this.RaisePropertyChanged("lineSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno sign
		{
			get
			{
				return this.signField;
			}
			set
			{
				this.signField = value;
				this.RaisePropertyChanged("sign");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool signSpecified
		{
			get
			{
				return this.signFieldSpecified;
			}
			set
			{
				this.signFieldSpecified = value;
				this.RaisePropertyChanged("signSpecified");
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
