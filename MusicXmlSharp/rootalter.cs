using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "root-alter")]
	public partial class rootalter : INotifyPropertyChanged
	{

		private yesno printobjectField;

		private bool printobjectFieldSpecified;

		private leftright locationField;

		private bool locationFieldSpecified;

		private decimal valueField;

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
		public leftright location
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
