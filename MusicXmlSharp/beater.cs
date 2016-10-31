using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class beater : INotifyPropertyChanged
	{

		private tipdirection tipField;

		private bool tipFieldSpecified;

		private beatervalue valueField;

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public tipdirection tip
		{
			get
			{
				return this.tipField;
			}
			set
			{
				this.tipField = value;
				this.RaisePropertyChanged("tip");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool tipSpecified
		{
			get
			{
				return this.tipFieldSpecified;
			}
			set
			{
				this.tipFieldSpecified = value;
				this.RaisePropertyChanged("tipSpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlTextAttribute()]
		public beatervalue Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
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
