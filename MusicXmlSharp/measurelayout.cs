using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-layout")]
	public partial class measurelayout : INotifyPropertyChanged
	{

		private decimal measuredistanceField;

		private bool measuredistanceFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("measure-distance")]
		public decimal measuredistance
		{
			get
			{
				return this.measuredistanceField;
			}
			set
			{
				this.measuredistanceField = value;
				this.RaisePropertyChanged("measuredistance");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool measuredistanceSpecified
		{
			get
			{
				return this.measuredistanceFieldSpecified;
			}
			set
			{
				this.measuredistanceFieldSpecified = value;
				this.RaisePropertyChanged("measuredistanceSpecified");
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
