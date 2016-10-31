using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class pitch : INotifyPropertyChanged
	{

		private step stepField;

		private decimal alterField;

		private bool alterFieldSpecified;

		private string octaveField;

		/// <remarks />
		public step step
		{
			get
			{
				return this.stepField;
			}
			set
			{
				this.stepField = value;
				this.RaisePropertyChanged("step");
			}
		}

		/// <remarks />
		public decimal alter
		{
			get
			{
				return this.alterField;
			}
			set
			{
				this.alterField = value;
				this.RaisePropertyChanged("alter");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool alterSpecified
		{
			get
			{
				return this.alterFieldSpecified;
			}
			set
			{
				this.alterFieldSpecified = value;
				this.RaisePropertyChanged("alterSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
		public string octave
		{
			get
			{
				return this.octaveField;
			}
			set
			{
				this.octaveField = value;
				this.RaisePropertyChanged("octave");
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
