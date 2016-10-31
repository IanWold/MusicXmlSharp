using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "tuplet-portion")]
	public partial class tupletportion : INotifyPropertyChanged
	{

		private tupletnumber tupletnumberField;

		private tuplettype tuplettypeField;

		private tupletdot[] tupletdotField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("tuplet-number")]
		public tupletnumber tupletnumber
		{
			get
			{
				return this.tupletnumberField;
			}
			set
			{
				this.tupletnumberField = value;
				this.RaisePropertyChanged("tupletnumber");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("tuplet-type")]
		public tuplettype tuplettype
		{
			get
			{
				return this.tuplettypeField;
			}
			set
			{
				this.tuplettypeField = value;
				this.RaisePropertyChanged("tuplettype");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("tuplet-dot")]
		public tupletdot[] tupletdot
		{
			get
			{
				return this.tupletdotField;
			}
			set
			{
				this.tupletdotField = value;
				this.RaisePropertyChanged("tupletdot");
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
