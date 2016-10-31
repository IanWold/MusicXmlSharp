using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class work : INotifyPropertyChanged
	{

		private string worknumberField;

		private string worktitleField;

		private opus opusField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("work-number")]
		public string worknumber
		{
			get
			{
				return this.worknumberField;
			}
			set
			{
				this.worknumberField = value;
				this.RaisePropertyChanged("worknumber");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("work-title")]
		public string worktitle
		{
			get
			{
				return this.worktitleField;
			}
			set
			{
				this.worktitleField = value;
				this.RaisePropertyChanged("worktitle");
			}
		}

		/// <remarks />
		public opus opus
		{
			get
			{
				return this.opusField;
			}
			set
			{
				this.opusField = value;
				this.RaisePropertyChanged("opus");
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
