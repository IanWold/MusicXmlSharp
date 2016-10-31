using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "figured-bass")]
	public partial class figuredbass : INotifyPropertyChanged
	{

		private figure[] figureField;

		private decimal durationField;

		private formattedtext footnoteField;

		private level levelField;

		private yesno printdotField;

		private bool printdotFieldSpecified;

		private yesno printlyricField;

		private bool printlyricFieldSpecified;

		private yesno parenthesesField;

		private bool parenthesesFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("figure")]
		public figure[] figure
		{
			get
			{
				return this.figureField;
			}
			set
			{
				this.figureField = value;
				this.RaisePropertyChanged("figure");
			}
		}

		/// <remarks />
		public decimal duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
				this.RaisePropertyChanged("duration");
			}
		}

		/// <remarks />
		public formattedtext footnote
		{
			get
			{
				return this.footnoteField;
			}
			set
			{
				this.footnoteField = value;
				this.RaisePropertyChanged("footnote");
			}
		}

		/// <remarks />
		public level level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
				this.RaisePropertyChanged("level");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("print-dot")]
		public yesno printdot
		{
			get
			{
				return this.printdotField;
			}
			set
			{
				this.printdotField = value;
				this.RaisePropertyChanged("printdot");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool printdotSpecified
		{
			get
			{
				return this.printdotFieldSpecified;
			}
			set
			{
				this.printdotFieldSpecified = value;
				this.RaisePropertyChanged("printdotSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("print-lyric")]
		public yesno printlyric
		{
			get
			{
				return this.printlyricField;
			}
			set
			{
				this.printlyricField = value;
				this.RaisePropertyChanged("printlyric");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool printlyricSpecified
		{
			get
			{
				return this.printlyricFieldSpecified;
			}
			set
			{
				this.printlyricFieldSpecified = value;
				this.RaisePropertyChanged("printlyricSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno parentheses
		{
			get
			{
				return this.parenthesesField;
			}
			set
			{
				this.parenthesesField = value;
				this.RaisePropertyChanged("parentheses");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool parenthesesSpecified
		{
			get
			{
				return this.parenthesesFieldSpecified;
			}
			set
			{
				this.parenthesesFieldSpecified = value;
				this.RaisePropertyChanged("parenthesesSpecified");
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
