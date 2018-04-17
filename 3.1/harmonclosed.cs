
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "harmon-closed")]
    public partial class harmonclosed : object, System.ComponentModel.INotifyPropertyChanged
    {

        private harmonclosedlocation locationField;

        private bool locationFieldSpecified;

        private harmonclosedvalue valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public harmonclosedlocation location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationSpecified
        {
            get
            {
                return this.locationFieldSpecified;
            }
            set
            {
                this.locationFieldSpecified = value;
                this.RaisePropertyChanged("locationSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public harmonclosedvalue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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