using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class rest : INotifyPropertyChanged
	{

		private step displaystepField;

		private string displayoctaveField;

		private yesno measureField;

		private bool measureFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("display-step")]
		public step displaystep
		{
			get
			{
				return this.displaystepField;
			}
			set
			{
				this.displaystepField = value;
				this.RaisePropertyChanged("displaystep");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("display-octave", DataType = "integer")]
		public string displayoctave
		{
			get
			{
				return this.displayoctaveField;
			}
			set
			{
				this.displayoctaveField = value;
				this.RaisePropertyChanged("displayoctave");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno measure
		{
			get
			{
				return this.measureField;
			}
			set
			{
				this.measureField = value;
				this.RaisePropertyChanged("measure");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool measureSpecified
		{
			get
			{
				return this.measureFieldSpecified;
			}
			set
			{
				this.measureFieldSpecified = value;
				this.RaisePropertyChanged("measureSpecified");
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
