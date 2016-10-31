using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-tuning")]
	public partial class stafftuning : INotifyPropertyChanged
	{

		private step tuningstepField;

		private decimal tuningalterField;

		private bool tuningalterFieldSpecified;

		private string tuningoctaveField;

		private string lineField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("tuning-step")]
		public step tuningstep
		{
			get
			{
				return this.tuningstepField;
			}
			set
			{
				this.tuningstepField = value;
				this.RaisePropertyChanged("tuningstep");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("tuning-alter")]
		public decimal tuningalter
		{
			get
			{
				return this.tuningalterField;
			}
			set
			{
				this.tuningalterField = value;
				this.RaisePropertyChanged("tuningalter");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool tuningalterSpecified
		{
			get
			{
				return this.tuningalterFieldSpecified;
			}
			set
			{
				this.tuningalterFieldSpecified = value;
				this.RaisePropertyChanged("tuningalterSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("tuning-octave", DataType = "integer")]
		public string tuningoctave
		{
			get
			{
				return this.tuningoctaveField;
			}
			set
			{
				this.tuningoctaveField = value;
				this.RaisePropertyChanged("tuningoctave");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string line
		{
			get
			{
				return this.lineField;
			}
			set
			{
				this.lineField = value;
				this.RaisePropertyChanged("line");
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
