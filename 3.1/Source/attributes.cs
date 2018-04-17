
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class attributes : object, System.ComponentModel.INotifyPropertyChanged
    {

        private formattedtext footnoteField;

        private level levelField;

        private decimal divisionsField;

        private bool divisionsFieldSpecified;

        private key[] keyField;

        private time[] timeField;

        private string stavesField;

        private partsymbol partsymbolField;

        private string instrumentsField;

        private clef[] clefField;

        private staffdetails[] staffdetailsField;

        private transpose[] transposeField;

        private attributesDirective[] directiveField;

        private measurestyle[] measurestyleField;

        /// <remarks/>
        public formattedtext footnote
        {
            get
            {
                return this.footnoteField;
            }
            set
            {
                this.footnoteField = value;
                this.RaisePropertyChanged("footnote");
            }
        }

        /// <remarks/>
        public level level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
                this.RaisePropertyChanged("level");
            }
        }

        /// <remarks/>
        public decimal divisions
        {
            get
            {
                return this.divisionsField;
            }
            set
            {
                this.divisionsField = value;
                this.RaisePropertyChanged("divisions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool divisionsSpecified
        {
            get
            {
                return this.divisionsFieldSpecified;
            }
            set
            {
                this.divisionsFieldSpecified = value;
                this.RaisePropertyChanged("divisionsSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("key")]
        public key[] key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time")]
        public time[] time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
                this.RaisePropertyChanged("time");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string staves
        {
            get
            {
                return this.stavesField;
            }
            set
            {
                this.stavesField = value;
                this.RaisePropertyChanged("staves");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-symbol")]
        public partsymbol partsymbol
        {
            get
            {
                return this.partsymbolField;
            }
            set
            {
                this.partsymbolField = value;
                this.RaisePropertyChanged("partsymbol");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string instruments
        {
            get
            {
                return this.instrumentsField;
            }
            set
            {
                this.instrumentsField = value;
                this.RaisePropertyChanged("instruments");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clef")]
        public clef[] clef
        {
            get
            {
                return this.clefField;
            }
            set
            {
                this.clefField = value;
                this.RaisePropertyChanged("clef");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff-details")]
        public staffdetails[] staffdetails
        {
            get
            {
                return this.staffdetailsField;
            }
            set
            {
                this.staffdetailsField = value;
                this.RaisePropertyChanged("staffdetails");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transpose")]
        public transpose[] transpose
        {
            get
            {
                return this.transposeField;
            }
            set
            {
                this.transposeField = value;
                this.RaisePropertyChanged("transpose");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directive")]
        public attributesDirective[] directive
        {
            get
            {
                return this.directiveField;
            }
            set
            {
                this.directiveField = value;
                this.RaisePropertyChanged("directive");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("measure-style")]
        public measurestyle[] measurestyle
        {
            get
            {
                return this.measurestyleField;
            }
            set
            {
                this.measurestyleField = value;
                this.RaisePropertyChanged("measurestyle");
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