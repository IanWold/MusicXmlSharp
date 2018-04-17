
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "metronome-note")]
    public partial class metronomenote : object, System.ComponentModel.INotifyPropertyChanged
    {

        private notetypevalue metronometypeField;

        private empty[] metronomedotField;

        private metronomebeam[] metronomebeamField;

        private metronometied metronometiedField;

        private metronometuplet metronometupletField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-type")]
        public notetypevalue metronometype
        {
            get
            {
                return this.metronometypeField;
            }
            set
            {
                this.metronometypeField = value;
                this.RaisePropertyChanged("metronometype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-dot")]
        public empty[] metronomedot
        {
            get
            {
                return this.metronomedotField;
            }
            set
            {
                this.metronomedotField = value;
                this.RaisePropertyChanged("metronomedot");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-beam")]
        public metronomebeam[] metronomebeam
        {
            get
            {
                return this.metronomebeamField;
            }
            set
            {
                this.metronomebeamField = value;
                this.RaisePropertyChanged("metronomebeam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-tied")]
        public metronometied metronometied
        {
            get
            {
                return this.metronometiedField;
            }
            set
            {
                this.metronometiedField = value;
                this.RaisePropertyChanged("metronometied");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metronome-tuplet")]
        public metronometuplet metronometuplet
        {
            get
            {
                return this.metronometupletField;
            }
            set
            {
                this.metronometupletField = value;
                this.RaisePropertyChanged("metronometuplet");
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