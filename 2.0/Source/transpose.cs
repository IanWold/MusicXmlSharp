
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class transpose : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string diatonicField;

        private decimal chromaticField;

        private string octavechangeField;

        private empty doubleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string diatonic
        {
            get
            {
                return this.diatonicField;
            }
            set
            {
                this.diatonicField = value;
                this.RaisePropertyChanged("diatonic");
            }
        }

        /// <remarks/>
        public decimal chromatic
        {
            get
            {
                return this.chromaticField;
            }
            set
            {
                this.chromaticField = value;
                this.RaisePropertyChanged("chromatic");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("octave-change", DataType = "integer")]
        public string octavechange
        {
            get
            {
                return this.octavechangeField;
            }
            set
            {
                this.octavechangeField = value;
                this.RaisePropertyChanged("octavechange");
            }
        }

        /// <remarks/>
        public empty @double
        {
            get
            {
                return this.doubleField;
            }
            set
            {
                this.doubleField = value;
                this.RaisePropertyChanged("double");
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