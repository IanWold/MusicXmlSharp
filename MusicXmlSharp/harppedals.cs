using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "harp-pedals")]
	public partial class harppedals : INotifyPropertyChanged
	{

		private pedaltuning[] pedaltuningField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("pedal-tuning")]
		public pedaltuning[] pedaltuning
		{
			get
			{
				return this.pedaltuningField;
			}
			set
			{
				this.pedaltuningField = value;
				this.RaisePropertyChanged("pedaltuning");
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
