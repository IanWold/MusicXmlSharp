
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class slash : object, System.ComponentModel.INotifyPropertyChanged
    {

        private notetypevalue slashtypeField;

        private empty[] slashdotField;

        private startstop typeField;

        private yesno usedotsField;

        private bool usedotsFieldSpecified;

        private yesno usestemsField;

        private bool usestemsFieldSpecified;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("use-stems")]
        public yesno usestems
        {
            get
            {
                return this.usestemsField;
            }
            set
            {
                this.usestemsField = value;
                this.RaisePropertyChanged("usestems");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usestemsSpecified
        {
            get
            {
                return this.usestemsFieldSpecified;
            }
            set
            {
                this.usestemsFieldSpecified = value;
                this.RaisePropertyChanged("usestemsSpecified");
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