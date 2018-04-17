
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class mordent : emptytrillsound
    {

        private yesno longField;

        private bool longFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno @long
        {
            get
            {
                return this.longField;
            }
            set
            {
                this.longField = value;
                this.RaisePropertyChanged("long");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool longSpecified
        {
            get
            {
                return this.longFieldSpecified;
            }
            set
            {
                this.longFieldSpecified = value;
                this.RaisePropertyChanged("longSpecified");
            }
        }
    }

}