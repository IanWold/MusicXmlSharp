using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class metronome : INotifyPropertyChanged
	{

		private object[] itemsField;

		private leftcenterright justifyField;

		private bool justifyFieldSpecified;

		private yesno parenthesesField;

		private bool parenthesesFieldSpecified;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("beat-unit", typeof(notetypevalue))]
		[System.Xml.Serialization.XmlElementAttribute("beat-unit-dot", typeof(empty))]
		[System.Xml.Serialization.XmlElementAttribute("metronome-note", typeof(metronomenote))]
		[System.Xml.Serialization.XmlElementAttribute("metronome-relation", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("per-minute", typeof(perminute))]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public leftcenterright justify
		{
			get
			{
				return this.justifyField;
			}
			set
			{
				this.justifyField = value;
				this.RaisePropertyChanged("justify");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool justifySpecified
		{
			get
			{
				return this.justifyFieldSpecified;
			}
			set
			{
				this.justifyFieldSpecified = value;
				this.RaisePropertyChanged("justifySpecified");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public yesno parentheses
		{
			get
			{
				return this.parenthesesField;
			}
			set
			{
				this.parenthesesField = value;
				this.RaisePropertyChanged("parentheses");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool parenthesesSpecified
		{
			get
			{
				return this.parenthesesFieldSpecified;
			}
			set
			{
				this.parenthesesFieldSpecified = value;
				this.RaisePropertyChanged("parenthesesSpecified");
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