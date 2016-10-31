using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName = "strong-accent")]
	public partial class strongaccent : emptyplacement
	{

		private updown typeField;

		public strongaccent()
		{
			this.typeField = updown.up;
		}

		/// <remarks />
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[DefaultValueAttribute(updown.up)]
		public updown type
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
	}

}
