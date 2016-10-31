using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class offset : INotifyPropertyChanged
	{

		private yesno soundField;

		private bool soundFieldSpecified;

		private decimal valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno sound
		{
			get
			{
				return this.soundField;
			}
			set
			{
				this.soundField = value;
				this.RaisePropertyChanged("sound");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool soundSpecified
		{
			get
			{
				return this.soundFieldSpecified;
			}
			set
			{
				this.soundFieldSpecified = value;
				this.RaisePropertyChanged("soundSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlTextAttribute()]
		public decimal Value
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
