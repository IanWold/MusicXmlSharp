
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class clef : object, System.ComponentModel.INotifyPropertyChanged
    {

        private clefsign signField;

        private string lineField;

        private string clefoctavechangeField;

        private string numberField;

        private yesno additionalField;

        private bool additionalFieldSpecified;

        private symbolsize sizeField;

        private bool sizeFieldSpecified;

        private yesno printobjectField;

        private bool printobjectFieldSpecified;

        /// <remarks/>
        public clefsign sign
        {
            get
            {
                return this.signField;
            }
            set
            {
                this.signField = value;
                this.RaisePropertyChanged("sign");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string line
        {
            get
            {
                return this.lineField;
            }
            set
            {
                this.lineField = value;
                this.RaisePropertyChanged("line");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clef-octave-change", DataType = "integer")]
        public string clefoctavechange
        {
            get
            {
                return this.clefoctavechangeField;
            }
            set
            {
                this.clefoctavechangeField = value;
                this.RaisePropertyChanged("clefoctavechange");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
                this.RaisePropertyChanged("number");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno additional
        {
            get
            {
                return this.additionalField;
            }
            set
            {
                this.additionalField = value;
                this.RaisePropertyChanged("additional");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool additionalSpecified
        {
            get
            {
                return this.additionalFieldSpecified;
            }
            set
            {
                this.additionalFieldSpecified = value;
                this.RaisePropertyChanged("additionalSpecified");
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
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject
        {
            get
            {
                return this.printobjectField;
            }
            set
            {
                this.printobjectField = value;
                this.RaisePropertyChanged("printobject");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified
        {
            get
            {
                return this.printobjectFieldSpecified;
            }
            set
            {
                this.printobjectFieldSpecified = value;
                this.RaisePropertyChanged("printobjectSpecified");
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