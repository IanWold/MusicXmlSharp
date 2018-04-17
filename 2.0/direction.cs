
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class direction : object, System.ComponentModel.INotifyPropertyChanged
    {

        private directiontype[] directiontypeField;

        private offset offsetField;

        private formattedtext footnoteField;

        private level levelField;

        private string voiceField;

        private string staffField;

        private sound soundField;

        private abovebelow placementField;

        private bool placementFieldSpecified;

        private yesno directiveField;

        private bool directiveFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("direction-type")]
        public directiontype[] directiontype
        {
            get
            {
                return this.directiontypeField;
            }
            set
            {
                this.directiontypeField = value;
                this.RaisePropertyChanged("directiontype");
            }
        }

        /// <remarks/>
        public offset offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
                this.RaisePropertyChanged("offset");
            }
        }

        /// <remarks/>
        public formattedtext footnote
        {
            get
            {
                return this.footnoteField;
            }
            set
            {
                this.footnoteField = value;
                this.RaisePropertyChanged("footnote");
            }
        }

        /// <remarks/>
        public level level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
                this.RaisePropertyChanged("level");
            }
        }

        /// <remarks/>
        public string voice
        {
            get
            {
                return this.voiceField;
            }
            set
            {
                this.voiceField = value;
                this.RaisePropertyChanged("voice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string staff
        {
            get
            {
                return this.staffField;
            }
            set
            {
                this.staffField = value;
                this.RaisePropertyChanged("staff");
            }
        }

        /// <remarks/>
        public sound sound
        {
            get
            {
                return this.soundField;
            }
            set
            {
                this.soundField = value;
                this.RaisePropertyChanged("sound");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement
        {
            get
            {
                return this.placementField;
            }
            set
            {
                this.placementField = value;
                this.RaisePropertyChanged("placement");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified
        {
            get
            {
                return this.placementFieldSpecified;
            }
            set
            {
                this.placementFieldSpecified = value;
                this.RaisePropertyChanged("placementSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno directive
        {
            get
            {
                return this.directiveField;
            }
            set
            {
                this.directiveField = value;
                this.RaisePropertyChanged("directive");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directiveSpecified
        {
            get
            {
                return this.directiveFieldSpecified;
            }
            set
            {
                this.directiveFieldSpecified = value;
                this.RaisePropertyChanged("directiveSpecified");
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