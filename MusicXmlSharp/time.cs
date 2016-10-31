using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class time : INotifyPropertyChanged
	{

		private object[] itemsField;

		private ItemsChoiceType9[] itemsElementNameField;

		private string numberField;

		private timesymbol symbolField;

		private bool symbolFieldSpecified;

		private timeseparator separatorField;

		private bool separatorFieldSpecified;

		private yesno printobjectField;

		private bool printobjectFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("beat-type", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("beats", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("interchangeable", typeof(interchangeable))]
		[System.Xml.Serialization.XmlElementAttribute("senza-misura", typeof(string))]
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
		public ItemsChoiceType9[] ItemsElementName
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
		public timesymbol symbol
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public timeseparator separator
		{
			get
			{
				return this.separatorField;
			}
			set
			{
				this.separatorField = value;
				this.RaisePropertyChanged("separator");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool separatorSpecified
		{
			get
			{
				return this.separatorFieldSpecified;
			}
			set
			{
				this.separatorFieldSpecified = value;
				this.RaisePropertyChanged("separatorSpecified");
			}
		}

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
