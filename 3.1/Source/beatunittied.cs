
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "beat-unit-tied")]
    public partial class beatunittied : object, System.ComponentModel.INotifyPropertyChanged
    {

        private notetypevalue beatunitField;

        private empty[] beatunitdotField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beat-unit")]
        public notetypevalue beatunit
        {
            get
            {
                return this.beatunitField;
            }
            set
            {
                this.beatunitField = value;
                this.RaisePropertyChanged("beatunit");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beat-unit-dot")]
        public empty[] beatunitdot
        {
            get
            {
                return this.beatunitdotField;
            }
            set
            {
                this.beatunitdotField = value;
                this.RaisePropertyChanged("beatunitdot");
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