using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class play : INotifyPropertyChanged
	{

		private object[] itemsField;

		private string idField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("ipa", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("mute", typeof(mute))]
		[System.Xml.Serialization.XmlElementAttribute("other-play", typeof(otherplay))]
		[System.Xml.Serialization.XmlElementAttribute("semi-pitched", typeof(semipitched))]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("id");
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
