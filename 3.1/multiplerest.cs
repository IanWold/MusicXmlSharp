
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "multiple-rest")]
    public partial class multiplerest : object, System.ComponentModel.INotifyPropertyChanged
    {

        private yesno usesymbolsField;

        private bool usesymbolsFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("use-symbols")]
        public yesno usesymbols
        {
            get
            {
                return this.usesymbolsField;
            }
            set
            {
                this.usesymbolsField = value;
                this.RaisePropertyChanged("usesymbols");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usesymbolsSpecified
        {
            get
            {
                return this.usesymbolsFieldSpecified;
            }
            set
            {
                this.usesymbolsFieldSpecified = value;
                this.RaisePropertyChanged("usesymbolsSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

}