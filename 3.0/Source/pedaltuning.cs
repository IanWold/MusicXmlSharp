
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "pedal-tuning")]
    public partial class pedaltuning : object, System.ComponentModel.INotifyPropertyChanged
    {

        private step pedalstepField;

        private decimal pedalalterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pedal-step")]
        public step pedalstep
        {
            get
            {
                return this.pedalstepField;
            }
            set
            {
                this.pedalstepField = value;
                this.RaisePropertyChanged("pedalstep");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pedal-alter")]
        public decimal pedalalter
        {
            get
            {
                return this.pedalalterField;
            }
            set
            {
                this.pedalalterField = value;
                this.RaisePropertyChanged("pedalalter");
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