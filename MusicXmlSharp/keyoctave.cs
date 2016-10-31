using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "key-octave")]
	public partial class keyoctave : INotifyPropertyChanged
	{

		private string numberField;

		private yesno cancelField;

		private bool cancelFieldSpecified;

		private string valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
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
		public yesno cancel
		{
			get
			{
				return this.cancelField;
			}
			set
			{
				this.cancelField = value;
				this.RaisePropertyChanged("cancel");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool cancelSpecified
		{
			get
			{
				return this.cancelFieldSpecified;
			}
			set
			{
				this.cancelFieldSpecified = value;
				this.RaisePropertyChanged("cancelSpecified");
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
