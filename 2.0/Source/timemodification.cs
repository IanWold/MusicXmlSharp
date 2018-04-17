
namespace MusicXml
{

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(metronometuplet))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "time-modification")]
    public partial class timemodification : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string actualnotesField;

        private string normalnotesField;

        private notetypevalue normaltypeField;

        private empty[] normaldotField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actual-notes", DataType = "nonNegativeInteger")]
        public string actualnotes
        {
            get
            {
                return this.actualnotesField;
            }
            set
            {
                this.actualnotesField = value;
                this.RaisePropertyChanged("actualnotes");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("normal-notes", DataType = "nonNegativeInteger")]
        public string normalnotes
        {
            get
            {
                return this.normalnotesField;
            }
            set
            {
                this.normalnotesField = value;
                this.RaisePropertyChanged("normalnotes");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("normal-type")]
        public notetypevalue normaltype
        {
            get
            {
                return this.normaltypeField;
            }
            set
            {
                this.normaltypeField = value;
                this.RaisePropertyChanged("normaltype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("normal-dot")]
        public empty[] normaldot
        {
            get
            {
                return this.normaldotField;
            }
            set
            {
                this.normaldotField = value;
                this.RaisePropertyChanged("normaldot");
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