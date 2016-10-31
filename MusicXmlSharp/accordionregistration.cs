using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "accordion-registration")]
	public partial class accordionregistration : INotifyPropertyChanged
	{

		private empty accordionhighField;

		private string accordionmiddleField;

		private empty accordionlowField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("accordion-high")]
		public empty accordionhigh
		{
			get
			{
				return this.accordionhighField;
			}
			set
			{
				this.accordionhighField = value;
				this.RaisePropertyChanged("accordionhigh");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("accordion-middle", DataType = "positiveInteger")]
		public string accordionmiddle
		{
			get
			{
				return this.accordionmiddleField;
			}
			set
			{
				this.accordionmiddleField = value;
				this.RaisePropertyChanged("accordionmiddle");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("accordion-low")]
		public empty accordionlow
		{
			get
			{
				return this.accordionlowField;
			}
			set
			{
				this.accordionlowField = value;
				this.RaisePropertyChanged("accordionlow");
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
