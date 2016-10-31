using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "pedal-tuning")]
	public partial class pedaltuning : INotifyPropertyChanged
	{

		private step pedalstepField;

		private decimal pedalalterField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("pedal-step")]
		public step pedalstep
		{
			get
			{
				return this.pedalstepField;
			}
			set
			{
				this.pedalstepField = value;
				this.RaisePropertyChanged("pedalstep");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("pedal-alter")]
		public decimal pedalalter
		{
			get
			{
				return this.pedalalterField;
			}
			set
			{
				this.pedalalterField = value;
				this.RaisePropertyChanged("pedalalter");
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
