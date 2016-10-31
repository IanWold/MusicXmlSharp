using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class appearance : INotifyPropertyChanged
	{

		private linewidth[] linewidthField;

		private notesize[] notesizeField;

		private distance[] distanceField;

		private otherappearance[] otherappearanceField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("line-width")]
		public linewidth[] linewidth
		{
			get
			{
				return this.linewidthField;
			}
			set
			{
				this.linewidthField = value;
				this.RaisePropertyChanged("linewidth");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("note-size")]
		public notesize[] notesize
		{
			get
			{
				return this.notesizeField;
			}
			set
			{
				this.notesizeField = value;
				this.RaisePropertyChanged("notesize");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("distance")]
		public distance[] distance
		{
			get
			{
				return this.distanceField;
			}
			set
			{
				this.distanceField = value;
				this.RaisePropertyChanged("distance");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("other-appearance")]
		public otherappearance[] otherappearance
		{
			get
			{
				return this.otherappearanceField;
			}
			set
			{
				this.otherappearanceField = value;
				this.RaisePropertyChanged("otherappearance");
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
