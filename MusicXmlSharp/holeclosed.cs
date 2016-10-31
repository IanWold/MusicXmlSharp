using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "hole-closed")]
	public partial class holeclosed : INotifyPropertyChanged
	{

		private holeclosedlocation locationField;

		private bool locationFieldSpecified;

		private holeclosedvalue valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public holeclosedlocation location
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
		[System.Xml.Serialization.XmlTextAttribute()]
		public holeclosedvalue Value
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
