using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class technical : INotifyPropertyChanged
	{

		private object[] itemsField;

		private ItemsChoiceType3[] itemsElementNameField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("arrow", typeof(arrow))]
		[System.Xml.Serialization.XmlElementAttribute("bend", typeof(bend))]
		[System.Xml.Serialization.XmlElementAttribute("double-tongue", typeof(emptyplacement))]
		[System.Xml.Serialization.XmlElementAttribute("down-bow", typeof(emptyplacement))]
		[System.Xml.Serialization.XmlElementAttribute("fingering", typeof(fingering))]
		[System.Xml.Serialization.XmlElementAttribute("fingernails", typeof(emptyplacement))]
		[System.Xml.Serialization.XmlElementAttribute("fret", typeof(fret))]
		[System.Xml.Serialization.XmlElementAttribute("hammer-on", typeof(hammeronpulloff))]
		[System.Xml.Serialization.XmlElementAttribute("handbell", typeof(handbell))]
		[System.Xml.Serialization.XmlElementAttribute("harmonic", typeof(harmonic))]
		[System.Xml.Serialization.XmlElementAttribute("heel", typeof(heeltoe))]
		[System.Xml.Serialization.XmlElementAttribute("hole", typeof(hole))]
		[System.Xml.Serialization.XmlElementAttribute("open-string", typeof(emptyplacement))]
		[System.Xml.Serialization.XmlElementAttribute("other-technical", typeof(placementtext))]
		[System.Xml.Serialization.XmlElementAttribute("pluck", typeof(placementtext))]
		[System.Xml.Serialization.XmlElementAttribute("pull-off", typeof(hammeronpulloff))]
		[System.Xml.Serialization.XmlElementAttribute("snap-pizzicato", typeof(emptyplacement))]
		[System.Xml.Serialization.XmlElementAttribute("stopped", typeof(emptyplacement))]
		[System.Xml.Serialization.XmlElementAttribute("string", typeof(@string))]
		[System.Xml.Serialization.XmlElementAttribute("tap", typeof(placementtext))]
		[System.Xml.Serialization.XmlElementAttribute("thumb-position", typeof(emptyplacement))]
		[System.Xml.Serialization.XmlElementAttribute("toe", typeof(heeltoe))]
		[System.Xml.Serialization.XmlElementAttribute("triple-tongue", typeof(emptyplacement))]
		[System.Xml.Serialization.XmlElementAttribute("up-bow", typeof(emptyplacement))]
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
		public ItemsChoiceType3[] ItemsElementName
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
