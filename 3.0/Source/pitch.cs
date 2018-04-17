
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class pitch : object, System.ComponentModel.INotifyPropertyChanged
    {

        private step stepField;

        private decimal alterField;

        private bool alterFieldSpecified;

        private string octaveField;

        /// <remarks/>
        public step step
        {
            get
            {
                return this.stepField;
            }
            set
            {
                this.stepField = value;
                this.RaisePropertyChanged("step");
            }
        }

        /// <remarks/>
        public decimal alter
        {
            get
            {
                return this.alterField;
            }
            set
            {
                this.alterField = value;
                this.RaisePropertyChanged("alter");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alterSpecified
        {
            get
            {
                return this.alterFieldSpecified;
            }
            set
            {
                this.alterFieldSpecified = value;
                this.RaisePropertyChanged("alterSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string octave
        {
            get
            {
                return this.octaveField;
            }
            set
            {
                this.octaveField = value;
                this.RaisePropertyChanged("octave");
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