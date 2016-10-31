using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-details")]
	public partial class staffdetails : INotifyPropertyChanged
	{

		private stafftype stafftypeField;

		private bool stafftypeFieldSpecified;

		private string stafflinesField;

		private stafftuning[] stafftuningField;

		private string capoField;

		private decimal staffsizeField;

		private bool staffsizeFieldSpecified;

		private string numberField;

		private showfrets showfretsField;

		private bool showfretsFieldSpecified;

		private yesno printobjectField;

		private bool printobjectFieldSpecified;

		private yesno printspacingField;

		private bool printspacingFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("staff-type")]
		public stafftype stafftype
		{
			get
			{
				return this.stafftypeField;
			}
			set
			{
				this.stafftypeField = value;
				this.RaisePropertyChanged("stafftype");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool stafftypeSpecified
		{
			get
			{
				return this.stafftypeFieldSpecified;
			}
			set
			{
				this.stafftypeFieldSpecified = value;
				this.RaisePropertyChanged("stafftypeSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("staff-lines", DataType = "nonNegativeInteger")]
		public string stafflines
		{
			get
			{
				return this.stafflinesField;
			}
			set
			{
				this.stafflinesField = value;
				this.RaisePropertyChanged("stafflines");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("staff-tuning")]
		public stafftuning[] stafftuning
		{
			get
			{
				return this.stafftuningField;
			}
			set
			{
				this.stafftuningField = value;
				this.RaisePropertyChanged("stafftuning");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
		public string capo
		{
			get
			{
				return this.capoField;
			}
			set
			{
				this.capoField = value;
				this.RaisePropertyChanged("capo");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("staff-size")]
		public decimal staffsize
		{
			get
			{
				return this.staffsizeField;
			}
			set
			{
				this.staffsizeField = value;
				this.RaisePropertyChanged("staffsize");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool staffsizeSpecified
		{
			get
			{
				return this.staffsizeFieldSpecified;
			}
			set
			{
				this.staffsizeFieldSpecified = value;
				this.RaisePropertyChanged("staffsizeSpecified");
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
		[System.Xml.Serialization.XmlAttributeAttribute("show-frets")]
		public showfrets showfrets
		{
			get
			{
				return this.showfretsField;
			}
			set
			{
				this.showfretsField = value;
				this.RaisePropertyChanged("showfrets");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool showfretsSpecified
		{
			get
			{
				return this.showfretsFieldSpecified;
			}
			set
			{
				this.showfretsFieldSpecified = value;
				this.RaisePropertyChanged("showfretsSpecified");
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

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("print-spacing")]
		public yesno printspacing
		{
			get
			{
				return this.printspacingField;
			}
			set
			{
				this.printspacingField = value;
				this.RaisePropertyChanged("printspacing");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool printspacingSpecified
		{
			get
			{
				return this.printspacingFieldSpecified;
			}
			set
			{
				this.printspacingFieldSpecified = value;
				this.RaisePropertyChanged("printspacingSpecified");
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
