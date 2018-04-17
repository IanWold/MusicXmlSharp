
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "metronome-tuplet")]
    public partial class metronometuplet : timemodification
    {

        private startstop typeField;

        private yesno bracketField;

        private bool bracketFieldSpecified;

        private showtuplet shownumberField;

        private bool shownumberFieldSpecified;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno bracket
        {
            get
            {
                return this.bracketField;
            }
            set
            {
                this.bracketField = value;
                this.RaisePropertyChanged("bracket");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bracketSpecified
        {
            get
            {
                return this.bracketFieldSpecified;
            }
            set
            {
                this.bracketFieldSpecified = value;
                this.RaisePropertyChanged("bracketSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("show-number")]
        public showtuplet shownumber
        {
            get
            {
                return this.shownumberField;
            }
            set
            {
                this.shownumberField = value;
                this.RaisePropertyChanged("shownumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shownumberSpecified
        {
            get
            {
                return this.shownumberFieldSpecified;
            }
            set
            {
                this.shownumberFieldSpecified = value;
                this.RaisePropertyChanged("shownumberSpecified");
            }
        }
    }

}