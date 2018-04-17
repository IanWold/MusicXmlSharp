
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class frame : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string framestringsField;

        private string framefretsField;

        private firstfret firstfretField;

        private framenote[] framenoteField;

        private decimal defaultxField;

        private bool defaultxFieldSpecified;

        private decimal defaultyField;

        private bool defaultyFieldSpecified;

        private decimal relativexField;

        private bool relativexFieldSpecified;

        private decimal relativeyField;

        private bool relativeyFieldSpecified;

        private string colorField;

        private leftcenterright halignField;

        private bool halignFieldSpecified;

        private valignimage valignField;

        private bool valignFieldSpecified;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string unplayedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("frame-strings", DataType = "positiveInteger")]
        public string framestrings
        {
            get
            {
                return this.framestringsField;
            }
            set
            {
                this.framestringsField = value;
                this.RaisePropertyChanged("framestrings");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("frame-frets", DataType = "positiveInteger")]
        public string framefrets
        {
            get
            {
                return this.framefretsField;
            }
            set
            {
                this.framefretsField = value;
                this.RaisePropertyChanged("framefrets");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("first-fret")]
        public firstfret firstfret
        {
            get
            {
                return this.firstfretField;
            }
            set
            {
                this.firstfretField = value;
                this.RaisePropertyChanged("firstfret");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("frame-note")]
        public framenote[] framenote
        {
            get
            {
                return this.framenoteField;
            }
            set
            {
                this.framenoteField = value;
                this.RaisePropertyChanged("framenote");
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public leftcenterright halign
        {
            get
            {
                return this.halignField;
            }
            set
            {
                this.halignField = value;
                this.RaisePropertyChanged("halign");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool halignSpecified
        {
            get
            {
                return this.halignFieldSpecified;
            }
            set
            {
                this.halignFieldSpecified = value;
                this.RaisePropertyChanged("halignSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public valignimage valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
                this.RaisePropertyChanged("valign");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
                this.RaisePropertyChanged("valignSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
                this.RaisePropertyChanged("height");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
                this.RaisePropertyChanged("heightSpecified");
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string unplayed
        {
            get
            {
                return this.unplayedField;
            }
            set
            {
                this.unplayedField = value;
                this.RaisePropertyChanged("unplayed");
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