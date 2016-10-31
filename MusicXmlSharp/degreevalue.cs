using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-value")]
	public partial class degreevalue : INotifyPropertyChanged
	{

		private degreesymbolvalue symbolField;

		private bool symbolFieldSpecified;

		private string textField;

		private string valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public degreesymbolvalue symbol
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
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
		public string text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
				this.RaisePropertyChanged("text");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")]
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
