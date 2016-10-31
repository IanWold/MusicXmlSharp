using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class cancel : INotifyPropertyChanged
	{

		private cancellocation locationField;

		private bool locationFieldSpecified;

		private string valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public cancellocation location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
				this.RaisePropertyChanged("location");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool locationSpecified
		{
			get
			{
				return this.locationFieldSpecified;
			}
			set
			{
				this.locationFieldSpecified = value;
				this.RaisePropertyChanged("locationSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
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
