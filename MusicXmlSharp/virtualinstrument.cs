using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "virtual-instrument")]
	public partial class virtualinstrument : INotifyPropertyChanged
	{

		private string virtuallibraryField;

		private string virtualnameField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("virtual-library")]
		public string virtuallibrary
		{
			get
			{
				return this.virtuallibraryField;
			}
			set
			{
				this.virtuallibraryField = value;
				this.RaisePropertyChanged("virtuallibrary");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("virtual-name")]
		public string virtualname
		{
			get
			{
				return this.virtualnameField;
			}
			set
			{
				this.virtualnameField = value;
				this.RaisePropertyChanged("virtualname");
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
