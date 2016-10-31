using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class scordatura : INotifyPropertyChanged
	{

		private accord[] accordField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("accord")]
		public accord[] accord
		{
			get
			{
				return this.accordField;
			}
			set
			{
				this.accordField = value;
				this.RaisePropertyChanged("accord");
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
