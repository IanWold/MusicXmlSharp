using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "frame-note")]
	public partial class framenote : INotifyPropertyChanged
	{

		private @string stringField;

		private fret fretField;

		private fingering fingeringField;

		private barre barreField;

		/// <remarks />
		public @string @string
		{
			get
			{
				return this.stringField;
			}
			set
			{
				this.stringField = value;
				this.RaisePropertyChanged("string");
			}
		}

		/// <remarks />
		public fret fret
		{
			get
			{
				return this.fretField;
			}
			set
			{
				this.fretField = value;
				this.RaisePropertyChanged("fret");
			}
		}

		/// <remarks />
		public fingering fingering
		{
			get
			{
				return this.fingeringField;
			}
			set
			{
				this.fingeringField = value;
				this.RaisePropertyChanged("fingering");
			}
		}

		/// <remarks />
		public barre barre
		{
			get
			{
				return this.barreField;
			}
			set
			{
				this.barreField = value;
				this.RaisePropertyChanged("barre");
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
