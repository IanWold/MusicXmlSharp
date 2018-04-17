
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "page-margins")]
    public partial class pagemargins : object, System.ComponentModel.INotifyPropertyChanged
    {

        private decimal leftmarginField;

        private decimal rightmarginField;

        private decimal topmarginField;

        private decimal bottommarginField;

        private margintype typeField;

        private bool typeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("left-margin")]
        public decimal leftmargin
        {
            get
            {
                return this.leftmarginField;
            }
            set
            {
                this.leftmarginField = value;
                this.RaisePropertyChanged("leftmargin");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("right-margin")]
        public decimal rightmargin
        {
            get
            {
                return this.rightmarginField;
            }
            set
            {
                this.rightmarginField = value;
                this.RaisePropertyChanged("rightmargin");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("top-margin")]
        public decimal topmargin
        {
            get
            {
                return this.topmarginField;
            }
            set
            {
                this.topmarginField = value;
                this.RaisePropertyChanged("topmargin");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bottom-margin")]
        public decimal bottommargin
        {
            get
            {
                return this.bottommarginField;
            }
            set
            {
                this.bottommarginField = value;
                this.RaisePropertyChanged("bottommargin");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public margintype type
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
                this.RaisePropertyChanged("typeSpecified");
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