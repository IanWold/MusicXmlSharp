
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "beat-repeat")]
    public partial class beatrepeat : object, System.ComponentModel.INotifyPropertyChanged
    {

        private notetypevalue slashtypeField;

        private empty[] slashdotField;

        private string[] exceptvoiceField;

        private startstop typeField;

        private string slashesField;

        private yesno usedotsField;

        private bool usedotsFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("slash-type")]
        public notetypevalue slashtype
        {
            get
            {
                return this.slashtypeField;
            }
            set
            {
                this.slashtypeField = value;
                this.RaisePropertyChanged("slashtype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("slash-dot")]
        public empty[] slashdot
        {
            get
            {
                return this.slashdotField;
            }
            set
            {
                this.slashdotField = value;
                this.RaisePropertyChanged("slashdot");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("except-voice")]
        public string[] exceptvoice
        {
            get
            {
                return this.exceptvoiceField;
            }
            set
            {
                this.exceptvoiceField = value;
                this.RaisePropertyChanged("exceptvoice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstop type
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string slashes
        {
            get
            {
                return this.slashesField;
            }
            set
            {
                this.slashesField = value;
                this.RaisePropertyChanged("slashes");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("use-dots")]
        public yesno usedots
        {
            get
            {
                return this.usedotsField;
            }
            set
            {
                this.usedotsField = value;
                this.RaisePropertyChanged("usedots");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedotsSpecified
        {
            get
            {
                return this.usedotsFieldSpecified;
            }
            set
            {
                this.usedotsFieldSpecified = value;
                this.RaisePropertyChanged("usedotsSpecified");
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