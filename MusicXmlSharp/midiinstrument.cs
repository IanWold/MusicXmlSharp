using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "midi-instrument")]
	public partial class midiinstrument : INotifyPropertyChanged
	{

		private string midichannelField;

		private string midinameField;

		private string midibankField;

		private string midiprogramField;

		private string midiunpitchedField;

		private decimal volumeField;

		private bool volumeFieldSpecified;

		private decimal panField;

		private bool panFieldSpecified;

		private decimal elevationField;

		private bool elevationFieldSpecified;

		private string idField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("midi-channel", DataType = "positiveInteger")]
		public string midichannel
		{
			get
			{
				return this.midichannelField;
			}
			set
			{
				this.midichannelField = value;
				this.RaisePropertyChanged("midichannel");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("midi-name")]
		public string midiname
		{
			get
			{
				return this.midinameField;
			}
			set
			{
				this.midinameField = value;
				this.RaisePropertyChanged("midiname");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("midi-bank", DataType = "positiveInteger")]
		public string midibank
		{
			get
			{
				return this.midibankField;
			}
			set
			{
				this.midibankField = value;
				this.RaisePropertyChanged("midibank");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("midi-program", DataType = "positiveInteger")]
		public string midiprogram
		{
			get
			{
				return this.midiprogramField;
			}
			set
			{
				this.midiprogramField = value;
				this.RaisePropertyChanged("midiprogram");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("midi-unpitched", DataType = "positiveInteger")]
		public string midiunpitched
		{
			get
			{
				return this.midiunpitchedField;
			}
			set
			{
				this.midiunpitchedField = value;
				this.RaisePropertyChanged("midiunpitched");
			}
		}

		/// <remarks />
		public decimal volume
		{
			get
			{
				return this.volumeField;
			}
			set
			{
				this.volumeField = value;
				this.RaisePropertyChanged("volume");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool volumeSpecified
		{
			get
			{
				return this.volumeFieldSpecified;
			}
			set
			{
				this.volumeFieldSpecified = value;
				this.RaisePropertyChanged("volumeSpecified");
			}
		}

		/// <remarks />
		public decimal pan
		{
			get
			{
				return this.panField;
			}
			set
			{
				this.panField = value;
				this.RaisePropertyChanged("pan");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool panSpecified
		{
			get
			{
				return this.panFieldSpecified;
			}
			set
			{
				this.panFieldSpecified = value;
				this.RaisePropertyChanged("panSpecified");
			}
		}

		/// <remarks />
		public decimal elevation
		{
			get
			{
				return this.elevationField;
			}
			set
			{
				this.elevationField = value;
				this.RaisePropertyChanged("elevation");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool elevationSpecified
		{
			get
			{
				return this.elevationFieldSpecified;
			}
			set
			{
				this.elevationFieldSpecified = value;
				this.RaisePropertyChanged("elevationSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("id");
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
