
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accidental-mark")]
    public partial class accidentalmark : object, System.ComponentModel.INotifyPropertyChanged
    {

        private yesno parenthesesField;

        private bool parenthesesFieldSpecified;

        private yesno bracketField;

        private bool bracketFieldSpecified;

        private symbolsize sizeField;

        private bool sizeFieldSpecified;

        private abovebelow placementField;

        private bool placementFieldSpecified;

        private string smuflField;

        private string idField;

        private accidentalvalue valueField;

        /// <remarks/>
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

        /// <remarks/>
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public symbolsize size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
                this.RaisePropertyChanged("size");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified
        {
            get
            {
                return this.sizeFieldSpecified;
            }
            set
            {
                this.sizeFieldSpecified = value;
                this.RaisePropertyChanged("sizeSpecified");
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl
        {
            get
            {
                return this.smuflField;
            }
            set
            {
                this.smuflField = value;
                this.RaisePropertyChanged("smufl");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public accidentalvalue Value
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