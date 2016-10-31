using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-line")]
	public partial class emptyline : INotifyPropertyChanged
	{

		private lineshape lineshapeField;

		private bool lineshapeFieldSpecified;

		private linetype linetypeField;

		private bool linetypeFieldSpecified;

		private decimal dashlengthField;

		private bool dashlengthFieldSpecified;

		private decimal spacelengthField;

		private bool spacelengthFieldSpecified;

		private abovebelow placementField;

		private bool placementFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("line-shape")]
		public lineshape lineshape
		{
			get
			{
				return this.lineshapeField;
			}
			set
			{
				this.lineshapeField = value;
				this.RaisePropertyChanged("lineshape");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool lineshapeSpecified
		{
			get
			{
				return this.lineshapeFieldSpecified;
			}
			set
			{
				this.lineshapeFieldSpecified = value;
				this.RaisePropertyChanged("lineshapeSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("line-type")]
		public linetype linetype
		{
			get
			{
				return this.linetypeField;
			}
			set
			{
				this.linetypeField = value;
				this.RaisePropertyChanged("linetype");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool linetypeSpecified
		{
			get
			{
				return this.linetypeFieldSpecified;
			}
			set
			{
				this.linetypeFieldSpecified = value;
				this.RaisePropertyChanged("linetypeSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
		public decimal dashlength
		{
			get
			{
				return this.dashlengthField;
			}
			set
			{
				this.dashlengthField = value;
				this.RaisePropertyChanged("dashlength");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool dashlengthSpecified
		{
			get
			{
				return this.dashlengthFieldSpecified;
			}
			set
			{
				this.dashlengthFieldSpecified = value;
				this.RaisePropertyChanged("dashlengthSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("space-length")]
		public decimal spacelength
		{
			get
			{
				return this.spacelengthField;
			}
			set
			{
				this.spacelengthField = value;
				this.RaisePropertyChanged("spacelength");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool spacelengthSpecified
		{
			get
			{
				return this.spacelengthFieldSpecified;
			}
			set
			{
				this.spacelengthFieldSpecified = value;
				this.RaisePropertyChanged("spacelengthSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public abovebelow placement
		{
			get
			{
				return this.placementField;
			}
			set
			{
				this.placementField = value;
				this.RaisePropertyChanged("placement");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool placementSpecified
		{
			get
			{
				return this.placementFieldSpecified;
			}
			set
			{
				this.placementFieldSpecified = value;
				this.RaisePropertyChanged("placementSpecified");
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
