using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class root : INotifyPropertyChanged
	{

		private rootstep rootstepField;

		private rootalter rootalterField;

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("root-step")]
		public rootstep rootstep
		{
			get
			{
				return this.rootstepField;
			}
			set
			{
				this.rootstepField = value;
				this.RaisePropertyChanged("rootstep");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("root-alter")]
		public rootalter rootalter
		{
			get
			{
				return this.rootalterField;
			}
			set
			{
				this.rootalterField = value;
				this.RaisePropertyChanged("rootalter");
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
