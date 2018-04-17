
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "harp-pedals")]
    public partial class harppedals : object, System.ComponentModel.INotifyPropertyChanged
    {

        private pedaltuning[] pedaltuningField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pedal-tuning")]
        public pedaltuning[] pedaltuning
        {
            get
            {
                return this.pedaltuningField;
            }
            set
            {
                this.pedaltuningField = value;
                this.RaisePropertyChanged("pedaltuning");
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