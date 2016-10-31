using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class bend : INotifyPropertyChanged
	{

		private decimal bendalterField;

		private empty itemField;

		private ItemChoiceType1 itemElementNameField;

		private placementtext withbarField;

		private yesno accelerateField;

		private bool accelerateFieldSpecified;

		private decimal beatsField;

		private bool beatsFieldSpecified;

		private decimal firstbeatField;

		private bool firstbeatFieldSpecified;

		private decimal lastbeatField;

		private bool lastbeatFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("bend-alter")]
		public decimal bendalter
		{
			get
			{
				return this.bendalterField;
			}
			set
			{
				this.bendalterField = value;
				this.RaisePropertyChanged("bendalter");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("pre-bend", typeof(empty))]
		[System.Xml.Serialization.XmlElementAttribute("release", typeof(empty))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
		public empty Item
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
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ItemChoiceType1 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("with-bar")]
		public placementtext withbar
		{
			get
			{
				return this.withbarField;
			}
			set
			{
				this.withbarField = value;
				this.RaisePropertyChanged("withbar");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno accelerate
		{
			get
			{
				return this.accelerateField;
			}
			set
			{
				this.accelerateField = value;
				this.RaisePropertyChanged("accelerate");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool accelerateSpecified
		{
			get
			{
				return this.accelerateFieldSpecified;
			}
			set
			{
				this.accelerateFieldSpecified = value;
				this.RaisePropertyChanged("accelerateSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal beats
		{
			get
			{
				return this.beatsField;
			}
			set
			{
				this.beatsField = value;
				this.RaisePropertyChanged("beats");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool beatsSpecified
		{
			get
			{
				return this.beatsFieldSpecified;
			}
			set
			{
				this.beatsFieldSpecified = value;
				this.RaisePropertyChanged("beatsSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("first-beat")]
		public decimal firstbeat
		{
			get
			{
				return this.firstbeatField;
			}
			set
			{
				this.firstbeatField = value;
				this.RaisePropertyChanged("firstbeat");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool firstbeatSpecified
		{
			get
			{
				return this.firstbeatFieldSpecified;
			}
			set
			{
				this.firstbeatFieldSpecified = value;
				this.RaisePropertyChanged("firstbeatSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("last-beat")]
		public decimal lastbeat
		{
			get
			{
				return this.lastbeatField;
			}
			set
			{
				this.lastbeatField = value;
				this.RaisePropertyChanged("lastbeat");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool lastbeatSpecified
		{
			get
			{
				return this.lastbeatFieldSpecified;
			}
			set
			{
				this.lastbeatFieldSpecified = value;
				this.RaisePropertyChanged("lastbeatSpecified");
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
