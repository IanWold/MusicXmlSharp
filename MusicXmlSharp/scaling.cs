using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class scaling : INotifyPropertyChanged
	{

		private decimal millimetersField;

		private decimal tenthsField;

		/// <remarks />
		public decimal millimeters
		{
			get
			{
				return this.millimetersField;
			}
			set
			{
				this.millimetersField = value;
				this.RaisePropertyChanged("millimeters");
			}
		}

		/// <remarks />
		public decimal tenths
		{
			get
			{
				return this.tenthsField;
			}
			set
			{
				this.tenthsField = value;
				this.RaisePropertyChanged("tenths");
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
