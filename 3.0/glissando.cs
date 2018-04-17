
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class glissando : object, System.ComponentModel.INotifyPropertyChanged
    {

        private startstop typeField;

        private string numberField;

        private linetype linetypeField;

        private bool linetypeFieldSpecified;

        private decimal dashlengthField;

        private bool dashlengthFieldSpecified;

        private decimal spacelengthField;

        private bool spacelengthFieldSpecified;

        private string valueField;

        public glissando()
        {
            this.numberField = "1";
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
        [System.ComponentModel.DefaultValueAttribute("1")]
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
        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashlength
        {
            get
            {
                return this.dashlengthField;
            }
            set
            {
                this.dashlengthField = value;
                this.RaisePropertyChanged("dashlength");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashlengthSpecified
        {
            get
            {
                return this.dashlengthFieldSpecified;
            }
            set
            {
                this.dashlengthFieldSpecified = value;
                this.RaisePropertyChanged("dashlengthSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spacelength
        {
            get
            {
                return this.spacelengthField;
            }
            set
            {
                this.spacelengthField = value;
                this.RaisePropertyChanged("spacelength");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spacelengthSpecified
        {
            get
            {
                return this.spacelengthFieldSpecified;
            }
            set
            {
                this.spacelengthFieldSpecified = value;
                this.RaisePropertyChanged("spacelengthSpecified");
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