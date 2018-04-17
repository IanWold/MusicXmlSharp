
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "frame-note")]
    public partial class framenote : object, System.ComponentModel.INotifyPropertyChanged
    {

        private @string stringField;

        private fret fretField;

        private fingering fingeringField;

        private barre barreField;

        /// <remarks/>
        public @string @string
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
                this.RaisePropertyChanged("string");
            }
        }

        /// <remarks/>
        public fret fret
        {
            get
            {
                return this.fretField;
            }
            set
            {
                this.fretField = value;
                this.RaisePropertyChanged("fret");
            }
        }

        /// <remarks/>
        public fingering fingering
        {
            get
            {
                return this.fingeringField;
            }
            set
            {
                this.fingeringField = value;
                this.RaisePropertyChanged("fingering");
            }
        }

        /// <remarks/>
        public barre barre
        {
            get
            {
                return this.barreField;
            }
            set
            {
                this.barreField = value;
                this.RaisePropertyChanged("barre");
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