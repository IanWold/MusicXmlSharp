using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-margins")]
	public partial class systemmargins : INotifyPropertyChanged
	{

		private decimal leftmarginField;

		private decimal rightmarginField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("left-margin")]
		public decimal leftmargin
		{
			get
			{
				return this.leftmarginField;
			}
			set
			{
				this.leftmarginField = value;
				this.RaisePropertyChanged("leftmargin");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("right-margin")]
		public decimal rightmargin
		{
			get
			{
				return this.rightmarginField;
			}
			set
			{
				this.rightmarginField = value;
				this.RaisePropertyChanged("rightmargin");
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
