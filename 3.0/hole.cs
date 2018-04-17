
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class hole : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string holetypeField;

        private holeclosed holeclosedField;

        private string holeshapeField;

        private abovebelow placementField;

        private bool placementFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hole-type")]
        public string holetype
        {
            get
            {
                return this.holetypeField;
            }
            set
            {
                this.holetypeField = value;
                this.RaisePropertyChanged("holetype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hole-closed")]
        public holeclosed holeclosed
        {
            get
            {
                return this.holeclosedField;
            }
            set
            {
                this.holeclosedField = value;
                this.RaisePropertyChanged("holeclosed");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hole-shape")]
        public string holeshape
        {
            get
            {
                return this.holeshapeField;
            }
            set
            {
                this.holeshapeField = value;
                this.RaisePropertyChanged("holeshape");
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