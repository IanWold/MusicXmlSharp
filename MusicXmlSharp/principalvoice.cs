using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "principal-voice")]
	public partial class principalvoice : INotifyPropertyChanged
	{

		private startstop typeField;

		private principalvoicesymbol symbolField;

		private string valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public startstop type
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
		public principalvoicesymbol symbol
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
