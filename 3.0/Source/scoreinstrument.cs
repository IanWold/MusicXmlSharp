
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "score-instrument")]
    public partial class scoreinstrument : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string instrumentnameField;

        private string instrumentabbreviationField;

        private string instrumentsoundField;

        private object itemField;

        private virtualinstrument virtualinstrumentField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("instrument-name")]
        public string instrumentname
        {
            get
            {
                return this.instrumentnameField;
            }
            set
            {
                this.instrumentnameField = value;
                this.RaisePropertyChanged("instrumentname");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("instrument-abbreviation")]
        public string instrumentabbreviation
        {
            get
            {
                return this.instrumentabbreviationField;
            }
            set
            {
                this.instrumentabbreviationField = value;
                this.RaisePropertyChanged("instrumentabbreviation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("instrument-sound")]
        public string instrumentsound
        {
            get
            {
                return this.instrumentsoundField;
            }
            set
            {
                this.instrumentsoundField = value;
                this.RaisePropertyChanged("instrumentsound");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ensemble", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("solo", typeof(empty))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("virtual-instrument")]
        public virtualinstrument virtualinstrument
        {
            get
            {
                return this.virtualinstrumentField;
            }
            set
            {
                this.virtualinstrumentField = value;
                this.RaisePropertyChanged("virtualinstrument");
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