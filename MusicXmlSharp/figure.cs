using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class figure : INotifyPropertyChanged
	{

		private styletext prefixField;

		private styletext figurenumberField;

		private styletext suffixField;

		private extend extendField;

		/// <remarks />
		public styletext prefix
		{
			get
			{
				return this.prefixField;
			}
			set
			{
				this.prefixField = value;
				this.RaisePropertyChanged("prefix");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("figure-number")]
		public styletext figurenumber
		{
			get
			{
				return this.figurenumberField;
			}
			set
			{
				this.figurenumberField = value;
				this.RaisePropertyChanged("figurenumber");
			}
		}

		/// <remarks />
		public styletext suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
				this.RaisePropertyChanged("suffix");
			}
		}

		/// <remarks />
		public extend extend
		{
			get
			{
				return this.extendField;
			}
			set
			{
				this.extendField = value;
				this.RaisePropertyChanged("extend");
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
