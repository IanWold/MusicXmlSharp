
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class beam : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string numberField;

        private yesno repeaterField;

        private bool repeaterFieldSpecified;

        private fan fanField;

        private bool fanFieldSpecified;

        private string colorField;

        private string idField;

        private beamvalue valueField;

        public beam()
        {
            this.numberField = "1";
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno repeater
        {
            get
            {
                return this.repeaterField;
            }
            set
            {
                this.repeaterField = value;
                this.RaisePropertyChanged("repeater");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool repeaterSpecified
        {
            get
            {
                return this.repeaterFieldSpecified;
            }
            set
            {
                this.repeaterFieldSpecified = value;
                this.RaisePropertyChanged("repeaterSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public fan fan
        {
            get
            {
                return this.fanField;
            }
            set
            {
                this.fanField = value;
                this.RaisePropertyChanged("fan");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fanSpecified
        {
            get
            {
                return this.fanFieldSpecified;
            }
            set
            {
                this.fanFieldSpecified = value;
                this.RaisePropertyChanged("fanSpecified");
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
        public beamvalue Value
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