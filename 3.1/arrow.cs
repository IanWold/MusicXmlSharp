
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class arrow : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        private abovebelow placementField;

        private bool placementFieldSpecified;

        private string smuflField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("arrow-direction", typeof(arrowdirection))]
        [System.Xml.Serialization.XmlElementAttribute("arrow-style", typeof(arrowstyle))]
        [System.Xml.Serialization.XmlElementAttribute("arrowhead", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("circular-arrow", typeof(circulararrow))]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string smufl
        {
            get
            {
                return this.smuflField;
            }
            set
            {
                this.smuflField = value;
                this.RaisePropertyChanged("smufl");
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