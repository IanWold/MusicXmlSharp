
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-line")]
    public partial class emptyline : object, System.ComponentModel.INotifyPropertyChanged
    {

        private lineshape lineshapeField;

        private bool lineshapeFieldSpecified;

        private linetype linetypeField;

        private bool linetypeFieldSpecified;

        private abovebelow placementField;

        private bool placementFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("line-shape")]
        public lineshape lineshape
        {
            get
            {
                return this.lineshapeField;
            }
            set
            {
                this.lineshapeField = value;
                this.RaisePropertyChanged("lineshape");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineshapeSpecified
        {
            get
            {
                return this.lineshapeFieldSpecified;
            }
            set
            {
                this.lineshapeFieldSpecified = value;
                this.RaisePropertyChanged("lineshapeSpecified");
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