
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "octave-shift")]
    public partial class octaveshift : object, System.ComponentModel.INotifyPropertyChanged
    {

        private updownstopcontinue typeField;

        private string numberField;

        private string sizeField;

        private decimal dashlengthField;

        private bool dashlengthFieldSpecified;

        private decimal spacelengthField;

        private bool spacelengthFieldSpecified;

        private string idField;

        public octaveshift()
        {
            this.sizeField = "8";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public updownstopcontinue type
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("8")]
        public string size
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