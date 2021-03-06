
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class repeat : object, System.ComponentModel.INotifyPropertyChanged
    {

        private backwardforward directionField;

        private string timesField;

        private winged wingedField;

        private bool wingedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public backwardforward direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
                this.RaisePropertyChanged("direction");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string times
        {
            get
            {
                return this.timesField;
            }
            set
            {
                this.timesField = value;
                this.RaisePropertyChanged("times");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public winged winged
        {
            get
            {
                return this.wingedField;
            }
            set
            {
                this.wingedField = value;
                this.RaisePropertyChanged("winged");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wingedSpecified
        {
            get
            {
                return this.wingedFieldSpecified;
            }
            set
            {
                this.wingedFieldSpecified = value;
                this.RaisePropertyChanged("wingedSpecified");
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