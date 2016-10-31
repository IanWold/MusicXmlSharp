using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class encoding : INotifyPropertyChanged
	{

		private object[] itemsField;

		private ItemsChoiceType[] itemsElementNameField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("encoder", typeof(typedtext))]
		[System.Xml.Serialization.XmlElementAttribute("encoding-date", typeof(System.DateTime), DataType = "date")]
		[System.Xml.Serialization.XmlElementAttribute("encoding-description", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("software", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("supports", typeof(supports))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
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
		[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ItemsChoiceType[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
				this.RaisePropertyChanged("ItemsElementName");
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
