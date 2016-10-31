using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class forward : INotifyPropertyChanged
	{

		private decimal durationField;

		private formattedtext footnoteField;

		private level levelField;

		private string voiceField;

		private string staffField;

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
		public string voice
		{
			get
			{
				return this.voiceField;
			}
			set
			{
				this.voiceField = value;
				this.RaisePropertyChanged("voice");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string staff
		{
			get
			{
				return this.staffField;
			}
			set
			{
				this.staffField = value;
				this.RaisePropertyChanged("staff");
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
