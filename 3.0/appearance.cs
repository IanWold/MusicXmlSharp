
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class appearance : object, System.ComponentModel.INotifyPropertyChanged
    {

        private linewidth[] linewidthField;

        private notesize[] notesizeField;

        private distance[] distanceField;

        private otherappearance[] otherappearanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("line-width")]
        public linewidth[] linewidth
        {
            get
            {
                return this.linewidthField;
            }
            set
            {
                this.linewidthField = value;
                this.RaisePropertyChanged("linewidth");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("note-size")]
        public notesize[] notesize
        {
            get
            {
                return this.notesizeField;
            }
            set
            {
                this.notesizeField = value;
                this.RaisePropertyChanged("notesize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("distance")]
        public distance[] distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
                this.RaisePropertyChanged("distance");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("other-appearance")]
        public otherappearance[] otherappearance
        {
            get
            {
                return this.otherappearanceField;
            }
            set
            {
                this.otherappearanceField = value;
                this.RaisePropertyChanged("otherappearance");
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