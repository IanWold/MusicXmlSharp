
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "degree-alter")]
    public partial class degreealter : object, System.ComponentModel.INotifyPropertyChanged
    {

        private yesno plusminusField;

        private bool plusminusFieldSpecified;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("plus-minus")]
        public yesno plusminus
        {
            get
            {
                return this.plusminusField;
            }
            set
            {
                this.plusminusField = value;
                this.RaisePropertyChanged("plusminus");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plusminusSpecified
        {
            get
            {
                return this.plusminusFieldSpecified;
            }
            set
            {
                this.plusminusFieldSpecified = value;
                this.RaisePropertyChanged("plusminusSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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