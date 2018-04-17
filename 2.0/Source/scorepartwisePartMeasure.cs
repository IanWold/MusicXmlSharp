
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class scorepartwisePartMeasure : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        private string numberField;

        private yesno implicitField;

        private bool implicitFieldSpecified;

        private yesno noncontrollingField;

        private bool noncontrollingFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(attributes))]
        [System.Xml.Serialization.XmlElementAttribute("backup", typeof(backup))]
        [System.Xml.Serialization.XmlElementAttribute("barline", typeof(barline))]
        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark))]
        [System.Xml.Serialization.XmlElementAttribute("direction", typeof(direction))]
        [System.Xml.Serialization.XmlElementAttribute("figured-bass", typeof(figuredbass))]
        [System.Xml.Serialization.XmlElementAttribute("forward", typeof(forward))]
        [System.Xml.Serialization.XmlElementAttribute("grouping", typeof(grouping))]
        [System.Xml.Serialization.XmlElementAttribute("harmony", typeof(harmony))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(link))]
        [System.Xml.Serialization.XmlElementAttribute("note", typeof(note))]
        [System.Xml.Serialization.XmlElementAttribute("print", typeof(print))]
        [System.Xml.Serialization.XmlElementAttribute("sound", typeof(sound))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
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
        public yesno @implicit
        {
            get
            {
                return this.implicitField;
            }
            set
            {
                this.implicitField = value;
                this.RaisePropertyChanged("implicit");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool implicitSpecified
        {
            get
            {
                return this.implicitFieldSpecified;
            }
            set
            {
                this.implicitFieldSpecified = value;
                this.RaisePropertyChanged("implicitSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("non-controlling")]
        public yesno noncontrolling
        {
            get
            {
                return this.noncontrollingField;
            }
            set
            {
                this.noncontrollingField = value;
                this.RaisePropertyChanged("noncontrolling");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool noncontrollingSpecified
        {
            get
            {
                return this.noncontrollingFieldSpecified;
            }
            set
            {
                this.noncontrollingFieldSpecified = value;
                this.RaisePropertyChanged("noncontrollingSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
                this.RaisePropertyChanged("width");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
                this.RaisePropertyChanged("widthSpecified");
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