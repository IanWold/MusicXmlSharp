using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "page-layout")]
	public partial class pagelayout : INotifyPropertyChanged
	{

		private decimal pageheightField;

		private decimal pagewidthField;

		private pagemargins[] pagemarginsField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("page-height")]
		public decimal pageheight
		{
			get
			{
				return this.pageheightField;
			}
			set
			{
				this.pageheightField = value;
				this.RaisePropertyChanged("pageheight");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("page-width")]
		public decimal pagewidth
		{
			get
			{
				return this.pagewidthField;
			}
			set
			{
				this.pagewidthField = value;
				this.RaisePropertyChanged("pagewidth");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("page-margins")]
		public pagemargins[] pagemargins
		{
			get
			{
				return this.pagemarginsField;
			}
			set
			{
				this.pagemarginsField = value;
				this.RaisePropertyChanged("pagemargins");
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
