
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-margins")]
    public partial class systemmargins : object, System.ComponentModel.INotifyPropertyChanged
    {

        private decimal leftmarginField;

        private decimal rightmarginField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("left-margin")]
        public decimal leftmargin
        {
            get
            {
                return this.leftmarginField;
            }
            set
            {
                this.leftmarginField = value;
                this.RaisePropertyChanged("leftmargin");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("right-margin")]
        public decimal rightmargin
        {
            get
            {
                return this.rightmarginField;
            }
            set
            {
                this.rightmarginField = value;
                this.RaisePropertyChanged("rightmargin");
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