
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class bracket : object, System.ComponentModel.INotifyPropertyChanged
    {

        private startstop typeField;

        private string numberField;

        private lineend lineendField;

        private decimal endlengthField;

        private bool endlengthFieldSpecified;

        private linetype linetypeField;

        private bool linetypeFieldSpecified;

        private decimal defaultxField;

        private bool defaultxFieldSpecified;

        private decimal defaultyField;

        private bool defaultyFieldSpecified;

        private decimal relativexField;

        private bool relativexFieldSpecified;

        private decimal relativeyField;

        private bool relativeyFieldSpecified;

        private string colorField;

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
        [System.Xml.Serialization.XmlAttributeAttribute("line-end")]
        public lineend lineend
        {
            get
            {
                return this.lineendField;
            }
            set
            {
                this.lineendField = value;
                this.RaisePropertyChanged("lineend");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("end-length")]
        public decimal endlength
        {
            get
            {
                return this.endlengthField;
            }
            set
            {
                this.endlengthField = value;
                this.RaisePropertyChanged("endlength");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endlengthSpecified
        {
            get
            {
                return this.endlengthFieldSpecified;
            }
            set
            {
                this.endlengthFieldSpecified = value;
                this.RaisePropertyChanged("endlengthSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public linetype linetype
        {
            get
            {
                return this.linetypeField;
            }
            set
            {
                this.linetypeField = value;
                this.RaisePropertyChanged("linetype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool linetypeSpecified
        {
            get
            {
                return this.linetypeFieldSpecified;
            }
            set
            {
                this.linetypeFieldSpecified = value;
                this.RaisePropertyChanged("linetypeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx
        {
            get
            {
                return this.defaultxField;
            }
            set
            {
                this.defaultxField = value;
                this.RaisePropertyChanged("defaultx");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified
        {
            get
            {
                return this.defaultxFieldSpecified;
            }
            set
            {
                this.defaultxFieldSpecified = value;
                this.RaisePropertyChanged("defaultxSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty
        {
            get
            {
                return this.defaultyField;
            }
            set
            {
                this.defaultyField = value;
                this.RaisePropertyChanged("defaulty");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified
        {
            get
            {
                return this.defaultyFieldSpecified;
            }
            set
            {
                this.defaultyFieldSpecified = value;
                this.RaisePropertyChanged("defaultySpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex
        {
            get
            {
                return this.relativexField;
            }
            set
            {
                this.relativexField = value;
                this.RaisePropertyChanged("relativex");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified
        {
            get
            {
                return this.relativexFieldSpecified;
            }
            set
            {
                this.relativexFieldSpecified = value;
                this.RaisePropertyChanged("relativexSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey
        {
            get
            {
                return this.relativeyField;
            }
            set
            {
                this.relativeyField = value;
                this.RaisePropertyChanged("relativey");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified
        {
            get
            {
                return this.relativeyFieldSpecified;
            }
            set
            {
                this.relativeyFieldSpecified = value;
                this.RaisePropertyChanged("relativeySpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
                this.RaisePropertyChanged("color");
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