
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "wavy-line")]
    public partial class wavyline : object, System.ComponentModel.INotifyPropertyChanged
    {

        private startstopcontinue typeField;

        private string numberField;

        private decimal defaultxField;

        private bool defaultxFieldSpecified;

        private decimal defaultyField;

        private bool defaultyFieldSpecified;

        private decimal relativexField;

        private bool relativexFieldSpecified;

        private decimal relativeyField;

        private bool relativeyFieldSpecified;

        private abovebelow placementField;

        private bool placementFieldSpecified;

        private string colorField;

        private startnote startnoteField;

        private bool startnoteFieldSpecified;

        private trillstep trillstepField;

        private bool trillstepFieldSpecified;

        private twonoteturn twonoteturnField;

        private bool twonoteturnFieldSpecified;

        private yesno accelerateField;

        private bool accelerateFieldSpecified;

        private decimal beatsField;

        private bool beatsFieldSpecified;

        private decimal secondbeatField;

        private bool secondbeatFieldSpecified;

        private decimal lastbeatField;

        private bool lastbeatFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopcontinue type
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
        [System.Xml.Serialization.XmlAttributeAttribute("start-note")]
        public startnote startnote
        {
            get
            {
                return this.startnoteField;
            }
            set
            {
                this.startnoteField = value;
                this.RaisePropertyChanged("startnote");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startnoteSpecified
        {
            get
            {
                return this.startnoteFieldSpecified;
            }
            set
            {
                this.startnoteFieldSpecified = value;
                this.RaisePropertyChanged("startnoteSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("trill-step")]
        public trillstep trillstep
        {
            get
            {
                return this.trillstepField;
            }
            set
            {
                this.trillstepField = value;
                this.RaisePropertyChanged("trillstep");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trillstepSpecified
        {
            get
            {
                return this.trillstepFieldSpecified;
            }
            set
            {
                this.trillstepFieldSpecified = value;
                this.RaisePropertyChanged("trillstepSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("two-note-turn")]
        public twonoteturn twonoteturn
        {
            get
            {
                return this.twonoteturnField;
            }
            set
            {
                this.twonoteturnField = value;
                this.RaisePropertyChanged("twonoteturn");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool twonoteturnSpecified
        {
            get
            {
                return this.twonoteturnFieldSpecified;
            }
            set
            {
                this.twonoteturnFieldSpecified = value;
                this.RaisePropertyChanged("twonoteturnSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno accelerate
        {
            get
            {
                return this.accelerateField;
            }
            set
            {
                this.accelerateField = value;
                this.RaisePropertyChanged("accelerate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accelerateSpecified
        {
            get
            {
                return this.accelerateFieldSpecified;
            }
            set
            {
                this.accelerateFieldSpecified = value;
                this.RaisePropertyChanged("accelerateSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal beats
        {
            get
            {
                return this.beatsField;
            }
            set
            {
                this.beatsField = value;
                this.RaisePropertyChanged("beats");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beatsSpecified
        {
            get
            {
                return this.beatsFieldSpecified;
            }
            set
            {
                this.beatsFieldSpecified = value;
                this.RaisePropertyChanged("beatsSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("second-beat")]
        public decimal secondbeat
        {
            get
            {
                return this.secondbeatField;
            }
            set
            {
                this.secondbeatField = value;
                this.RaisePropertyChanged("secondbeat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool secondbeatSpecified
        {
            get
            {
                return this.secondbeatFieldSpecified;
            }
            set
            {
                this.secondbeatFieldSpecified = value;
                this.RaisePropertyChanged("secondbeatSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("last-beat")]
        public decimal lastbeat
        {
            get
            {
                return this.lastbeatField;
            }
            set
            {
                this.lastbeatField = value;
                this.RaisePropertyChanged("lastbeat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastbeatSpecified
        {
            get
            {
                return this.lastbeatFieldSpecified;
            }
            set
            {
                this.lastbeatFieldSpecified = value;
                this.RaisePropertyChanged("lastbeatSpecified");
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