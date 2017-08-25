using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class percussion : INotifyPropertyChanged
	{

		private object itemField;

		private enclosureshape enclosureField;

		private bool enclosureFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("beater", typeof(beater))]
		[System.Xml.Serialization.XmlElementAttribute("effect", typeof(effect))]
		[System.Xml.Serialization.XmlElementAttribute("glass", typeof(glass))]
		[System.Xml.Serialization.XmlElementAttribute("membrane", typeof(membrane))]
		[System.Xml.Serialization.XmlElementAttribute("metal", typeof(metal))]
		[System.Xml.Serialization.XmlElementAttribute("other-percussion", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("pitched", typeof(pitched))]
		[System.Xml.Serialization.XmlElementAttribute("stick", typeof(stick))]
		[System.Xml.Serialization.XmlElementAttribute("stick-location", typeof(sticklocation))]
		[System.Xml.Serialization.XmlElementAttribute("timpani", typeof(empty))]
		[System.Xml.Serialization.XmlElementAttribute("wood", typeof(wood))]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public enclosureshape enclosure
		{
			get
			{
				return this.enclosureField;
			}
			set
			{
				this.enclosureField = value;
				this.RaisePropertyChanged("enclosure");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool enclosureSpecified
		{
			get
			{
				return this.enclosureFieldSpecified;
			}
			set
			{
				this.enclosureFieldSpecified = value;
				this.RaisePropertyChanged("enclosureSpecified");
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