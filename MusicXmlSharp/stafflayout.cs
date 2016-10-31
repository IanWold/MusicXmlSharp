using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-layout")]
	public partial class stafflayout : INotifyPropertyChanged
	{

		private decimal staffdistanceField;

		private bool staffdistanceFieldSpecified;

		private string numberField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("staff-distance")]
		public decimal staffdistance
		{
			get
			{
				return this.staffdistanceField;
			}
			set
			{
				this.staffdistanceField = value;
				this.RaisePropertyChanged("staffdistance");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool staffdistanceSpecified
		{
			get
			{
				return this.staffdistanceFieldSpecified;
			}
			set
			{
				this.staffdistanceFieldSpecified = value;
				this.RaisePropertyChanged("staffdistanceSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
		public string number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.numberField = value;
				this.RaisePropertyChanged("number");
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
