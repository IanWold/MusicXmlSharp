
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class harmony : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        private kind[] kindField;

        private inversion[] inversionField;

        private bass[] bassField;

        private degree[] degreeField;

        private frame frameField;

        private offset offsetField;

        private formattedtext footnoteField;

        private level levelField;

        private string staffField;

        private harmonytype typeField;

        private bool typeFieldSpecified;

        private yesno printobjectField;

        private bool printobjectFieldSpecified;

        private yesno printframeField;

        private bool printframeFieldSpecified;

        private abovebelow placementField;

        private bool placementFieldSpecified;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("function", typeof(styletext))]
        [System.Xml.Serialization.XmlElementAttribute("root", typeof(root))]
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
        [System.Xml.Serialization.XmlElementAttribute("kind")]
        public kind[] kind
        {
            get
            {
                return this.kindField;
            }
            set
            {
                this.kindField = value;
                this.RaisePropertyChanged("kind");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inversion")]
        public inversion[] inversion
        {
            get
            {
                return this.inversionField;
            }
            set
            {
                this.inversionField = value;
                this.RaisePropertyChanged("inversion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bass")]
        public bass[] bass
        {
            get
            {
                return this.bassField;
            }
            set
            {
                this.bassField = value;
                this.RaisePropertyChanged("bass");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("degree")]
        public degree[] degree
        {
            get
            {
                return this.degreeField;
            }
            set
            {
                this.degreeField = value;
                this.RaisePropertyChanged("degree");
            }
        }

        /// <remarks/>
        public frame frame
        {
            get
            {
                return this.frameField;
            }
            set
            {
                this.frameField = value;
                this.RaisePropertyChanged("frame");
            }
        }

        /// <remarks/>
        public offset offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
                this.RaisePropertyChanged("offset");
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string staff
        {
            get
            {
                return this.staffField;
            }
            set
            {
                this.staffField = value;
                this.RaisePropertyChanged("staff");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public harmonytype type
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-frame")]
        public yesno printframe
        {
            get
            {
                return this.printframeField;
            }
            set
            {
                this.printframeField = value;
                this.RaisePropertyChanged("printframe");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printframeSpecified
        {
            get
            {
                return this.printframeFieldSpecified;
            }
            set
            {
                this.printframeFieldSpecified = value;
                this.RaisePropertyChanged("printframeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public abovebelow placement
        {
            get
            {
                return this.placementField;
            }
            set
            {
                this.placementField = value;
                this.RaisePropertyChanged("placement");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool placementSpecified
        {
            get
            {
                return this.placementFieldSpecified;
            }
            set
            {
                this.placementFieldSpecified = value;
                this.RaisePropertyChanged("placementSpecified");
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