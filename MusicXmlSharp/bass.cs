using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class bass : INotifyPropertyChanged
	{

		private bassstep bassstepField;

		private bassalter bassalterField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("bass-step")]
		public bassstep bassstep
		{
			get
			{
				return this.bassstepField;
			}
			set
			{
				this.bassstepField = value;
				this.RaisePropertyChanged("bassstep");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("bass-alter")]
		public bassalter bassalter
		{
			get
			{
				return this.bassalterField;
			}
			set
			{
				this.bassalterField = value;
				this.RaisePropertyChanged("bassalter");
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
