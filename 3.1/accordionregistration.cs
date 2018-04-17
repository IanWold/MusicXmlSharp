
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accordion-registration")]
    public partial class accordionregistration : object, System.ComponentModel.INotifyPropertyChanged
    {

        private empty accordionhighField;

        private string accordionmiddleField;

        private empty accordionlowField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accordion-high")]
        public empty accordionhigh
        {
            get
            {
                return this.accordionhighField;
            }
            set
            {
                this.accordionhighField = value;
                this.RaisePropertyChanged("accordionhigh");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accordion-middle", DataType = "positiveInteger")]
        public string accordionmiddle
        {
            get
            {
                return this.accordionmiddleField;
            }
            set
            {
                this.accordionmiddleField = value;
                this.RaisePropertyChanged("accordionmiddle");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accordion-low")]
        public empty accordionlow
        {
            get
            {
                return this.accordionlowField;
            }
            set
            {
                this.accordionlowField = value;
                this.RaisePropertyChanged("accordionlow");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("id");
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