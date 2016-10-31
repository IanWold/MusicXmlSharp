using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class backup : INotifyPropertyChanged
	{

		private decimal durationField;

		private formattedtext footnoteField;

		private level levelField;

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
