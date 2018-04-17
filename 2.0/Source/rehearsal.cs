
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class rehearsal : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string underlineField;

        private string overlineField;

        private string linethroughField;

        private string langField;

        private textdirection dirField;

        private bool dirFieldSpecified;

        private decimal rotationField;

        private bool rotationFieldSpecified;

        private rehearsalenclosure enclosureField;

        private bool enclosureFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string underline
        {
            get
            {
                return this.underlineField;
            }
            set
            {
                this.underlineField = value;
                this.RaisePropertyChanged("underline");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string overline
        {
            get
            {
                return this.overlineField;
            }
            set
            {
                this.overlineField = value;
                this.RaisePropertyChanged("overline");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-through", DataType = "nonNegativeInteger")]
        public string linethrough
        {
            get
            {
                return this.linethroughField;
            }
            set
            {
                this.linethroughField = value;
                this.RaisePropertyChanged("linethrough");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
                this.RaisePropertyChanged("lang");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public textdirection dir
        {
            get
            {
                return this.dirField;
            }
            set
            {
                this.dirField = value;
                this.RaisePropertyChanged("dir");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dirSpecified
        {
            get
            {
                return this.dirFieldSpecified;
            }
            set
            {
                this.dirFieldSpecified = value;
                this.RaisePropertyChanged("dirSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
                this.RaisePropertyChanged("rotation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rotationSpecified
        {
            get
            {
                return this.rotationFieldSpecified;
            }
            set
            {
                this.rotationFieldSpecified = value;
                this.RaisePropertyChanged("rotationSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public rehearsalenclosure enclosure
        {
            get
            {
                return this.enclosureField;
            }
            set
            {
                this.enclosureField = value;
                this.RaisePropertyChanged("enclosure");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enclosureSpecified
        {
            get
            {
                return this.enclosureFieldSpecified;
            }
            set
            {
                this.enclosureFieldSpecified = value;
                this.RaisePropertyChanged("enclosureSpecified");
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