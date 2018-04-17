
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "heel-toe")]
    public partial class heeltoe : emptyplacement
    {

        private yesno substitutionField;

        private bool substitutionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno substitution
        {
            get
            {
                return this.substitutionField;
            }
            set
            {
                this.substitutionField = value;
                this.RaisePropertyChanged("substitution");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool substitutionSpecified
        {
            get
            {
                return this.substitutionFieldSpecified;
            }
            set
            {
                this.substitutionFieldSpecified = value;
                this.RaisePropertyChanged("substitutionSpecified");
            }
        }
    }

}