using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class kind : INotifyPropertyChanged
	{

		private yesno usesymbolsField;

		private bool usesymbolsFieldSpecified;

		private string textField;

		private yesno stackdegreesField;

		private bool stackdegreesFieldSpecified;

		private yesno parenthesesdegreesField;

		private bool parenthesesdegreesFieldSpecified;

		private yesno bracketdegreesField;

		private bool bracketdegreesFieldSpecified;

		private leftcenterright halignField;

		private bool halignFieldSpecified;

		private valign valignField;

		private bool valignFieldSpecified;

		private kindvalue valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("use-symbols")]
		public yesno usesymbols
		{
			get
			{
				return this.usesymbolsField;
			}
			set
			{
				this.usesymbolsField = value;
				this.RaisePropertyChanged("usesymbols");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool usesymbolsSpecified
		{
			get
			{
				return this.usesymbolsFieldSpecified;
			}
			set
			{
				this.usesymbolsFieldSpecified = value;
				this.RaisePropertyChanged("usesymbolsSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
		public string text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
				this.RaisePropertyChanged("text");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("stack-degrees")]
		public yesno stackdegrees
		{
			get
			{
				return this.stackdegreesField;
			}
			set
			{
				this.stackdegreesField = value;
				this.RaisePropertyChanged("stackdegrees");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool stackdegreesSpecified
		{
			get
			{
				return this.stackdegreesFieldSpecified;
			}
			set
			{
				this.stackdegreesFieldSpecified = value;
				this.RaisePropertyChanged("stackdegreesSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("parentheses-degrees")]
		public yesno parenthesesdegrees
		{
			get
			{
				return this.parenthesesdegreesField;
			}
			set
			{
				this.parenthesesdegreesField = value;
				this.RaisePropertyChanged("parenthesesdegrees");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool parenthesesdegreesSpecified
		{
			get
			{
				return this.parenthesesdegreesFieldSpecified;
			}
			set
			{
				this.parenthesesdegreesFieldSpecified = value;
				this.RaisePropertyChanged("parenthesesdegreesSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("bracket-degrees")]
		public yesno bracketdegrees
		{
			get
			{
				return this.bracketdegreesField;
			}
			set
			{
				this.bracketdegreesField = value;
				this.RaisePropertyChanged("bracketdegrees");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool bracketdegreesSpecified
		{
			get
			{
				return this.bracketdegreesFieldSpecified;
			}
			set
			{
				this.bracketdegreesFieldSpecified = value;
				this.RaisePropertyChanged("bracketdegreesSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public leftcenterright halign
		{
			get
			{
				return this.halignField;
			}
			set
			{
				this.halignField = value;
				this.RaisePropertyChanged("halign");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool halignSpecified
		{
			get
			{
				return this.halignFieldSpecified;
			}
			set
			{
				this.halignFieldSpecified = value;
				this.RaisePropertyChanged("halignSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public valign valign
		{
			get
			{
				return this.valignField;
			}
			set
			{
				this.valignField = value;
				this.RaisePropertyChanged("valign");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool valignSpecified
		{
			get
			{
				return this.valignFieldSpecified;
			}
			set
			{
				this.valignFieldSpecified = value;
				this.RaisePropertyChanged("valignSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlTextAttribute()]
		public kindvalue Value
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
