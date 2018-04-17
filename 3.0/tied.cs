
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class tied : object, System.ComponentModel.INotifyPropertyChanged
    {

        private startstopcontinue typeField;

        private string numberField;

        private linetype linetypeField;

        private bool linetypeFieldSpecified;

        private decimal dashlengthField;

        private bool dashlengthFieldSpecified;

        private decimal spacelengthField;

        private bool spacelengthFieldSpecified;

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

        private overunder orientationField;

        private bool orientationFieldSpecified;

        private decimal bezieroffsetField;

        private bool bezieroffsetFieldSpecified;

        private decimal bezieroffset2Field;

        private bool bezieroffset2FieldSpecified;

        private decimal bezierxField;

        private bool bezierxFieldSpecified;

        private decimal bezieryField;

        private bool bezieryFieldSpecified;

        private decimal bezierx2Field;

        private bool bezierx2FieldSpecified;

        private decimal beziery2Field;

        private bool beziery2FieldSpecified;

        private string colorField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public overunder orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
                this.RaisePropertyChanged("orientation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orientationSpecified
        {
            get
            {
                return this.orientationFieldSpecified;
            }
            set
            {
                this.orientationFieldSpecified = value;
                this.RaisePropertyChanged("orientationSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-offset")]
        public decimal bezieroffset
        {
            get
            {
                return this.bezieroffsetField;
            }
            set
            {
                this.bezieroffsetField = value;
                this.RaisePropertyChanged("bezieroffset");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezieroffsetSpecified
        {
            get
            {
                return this.bezieroffsetFieldSpecified;
            }
            set
            {
                this.bezieroffsetFieldSpecified = value;
                this.RaisePropertyChanged("bezieroffsetSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-offset2")]
        public decimal bezieroffset2
        {
            get
            {
                return this.bezieroffset2Field;
            }
            set
            {
                this.bezieroffset2Field = value;
                this.RaisePropertyChanged("bezieroffset2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezieroffset2Specified
        {
            get
            {
                return this.bezieroffset2FieldSpecified;
            }
            set
            {
                this.bezieroffset2FieldSpecified = value;
                this.RaisePropertyChanged("bezieroffset2Specified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-x")]
        public decimal bezierx
        {
            get
            {
                return this.bezierxField;
            }
            set
            {
                this.bezierxField = value;
                this.RaisePropertyChanged("bezierx");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezierxSpecified
        {
            get
            {
                return this.bezierxFieldSpecified;
            }
            set
            {
                this.bezierxFieldSpecified = value;
                this.RaisePropertyChanged("bezierxSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-y")]
        public decimal beziery
        {
            get
            {
                return this.bezieryField;
            }
            set
            {
                this.bezieryField = value;
                this.RaisePropertyChanged("beziery");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezierySpecified
        {
            get
            {
                return this.bezieryFieldSpecified;
            }
            set
            {
                this.bezieryFieldSpecified = value;
                this.RaisePropertyChanged("bezierySpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-x2")]
        public decimal bezierx2
        {
            get
            {
                return this.bezierx2Field;
            }
            set
            {
                this.bezierx2Field = value;
                this.RaisePropertyChanged("bezierx2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bezierx2Specified
        {
            get
            {
                return this.bezierx2FieldSpecified;
            }
            set
            {
                this.bezierx2FieldSpecified = value;
                this.RaisePropertyChanged("bezierx2Specified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bezier-y2")]
        public decimal beziery2
        {
            get
            {
                return this.beziery2Field;
            }
            set
            {
                this.beziery2Field = value;
                this.RaisePropertyChanged("beziery2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool beziery2Specified
        {
            get
            {
                return this.beziery2FieldSpecified;
            }
            set
            {
                this.beziery2FieldSpecified = value;
                this.RaisePropertyChanged("beziery2Specified");
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