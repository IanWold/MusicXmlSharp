using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class mordent : emptytrillsound
	{

		private yesno longField;

		private bool longFieldSpecified;

		private abovebelow approachField;

		private bool approachFieldSpecified;

		private abovebelow departureField;

		private bool departureFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno @long
		{
			get
			{
				return this.longField;
			}
			set
			{
				this.longField = value;
				this.RaisePropertyChanged("long");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool longSpecified
		{
			get
			{
				return this.longFieldSpecified;
			}
			set
			{
				this.longFieldSpecified = value;
				this.RaisePropertyChanged("longSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public abovebelow approach
		{
			get
			{
				return this.approachField;
			}
			set
			{
				this.approachField = value;
				this.RaisePropertyChanged("approach");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool approachSpecified
		{
			get
			{
				return this.approachFieldSpecified;
			}
			set
			{
				this.approachFieldSpecified = value;
				this.RaisePropertyChanged("approachSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public abovebelow departure
		{
			get
			{
				return this.departureField;
			}
			set
			{
				this.departureField = value;
				this.RaisePropertyChanged("departure");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool departureSpecified
		{
			get
			{
				return this.departureFieldSpecified;
			}
			set
			{
				this.departureFieldSpecified = value;
				this.RaisePropertyChanged("departureSpecified");
			}
		}
	}

}
