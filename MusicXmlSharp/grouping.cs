using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class grouping : INotifyPropertyChanged
	{

		private feature[] featureField;

		private startstopsingle typeField;

		private string numberField;

		private string memberofField;

		public grouping()
		{
			this.numberField = "1";
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("feature")]
		public feature[] feature
		{
			get
			{
				return this.featureField;
			}
			set
			{
				this.featureField = value;
				this.RaisePropertyChanged("feature");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public startstopsingle type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("type");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
		[DefaultValueAttribute("1")]
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

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute("member-of", DataType = "token")]
		public string memberof
		{
			get
			{
				return this.memberofField;
			}
			set
			{
				this.memberofField = value;
				this.RaisePropertyChanged("memberof");
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
