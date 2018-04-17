
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "score-part")]
    public partial class scorepart : object, System.ComponentModel.INotifyPropertyChanged
    {

        private identification identificationField;

        private partname partnameField;

        private namedisplay partnamedisplayField;

        private partname partabbreviationField;

        private namedisplay partabbreviationdisplayField;

        private string[] groupField;

        private scoreinstrument[] scoreinstrumentField;

        private mididevice midideviceField;

        private midiinstrument[] midiinstrumentField;

        private string idField;

        /// <remarks/>
        public identification identification
        {
            get
            {
                return this.identificationField;
            }
            set
            {
                this.identificationField = value;
                this.RaisePropertyChanged("identification");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-name")]
        public partname partname
        {
            get
            {
                return this.partnameField;
            }
            set
            {
                this.partnameField = value;
                this.RaisePropertyChanged("partname");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-name-display")]
        public namedisplay partnamedisplay
        {
            get
            {
                return this.partnamedisplayField;
            }
            set
            {
                this.partnamedisplayField = value;
                this.RaisePropertyChanged("partnamedisplay");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation")]
        public partname partabbreviation
        {
            get
            {
                return this.partabbreviationField;
            }
            set
            {
                this.partabbreviationField = value;
                this.RaisePropertyChanged("partabbreviation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation-display")]
        public namedisplay partabbreviationdisplay
        {
            get
            {
                return this.partabbreviationdisplayField;
            }
            set
            {
                this.partabbreviationdisplayField = value;
                this.RaisePropertyChanged("partabbreviationdisplay");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("group")]
        public string[] group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
                this.RaisePropertyChanged("group");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("score-instrument")]
        public scoreinstrument[] scoreinstrument
        {
            get
            {
                return this.scoreinstrumentField;
            }
            set
            {
                this.scoreinstrumentField = value;
                this.RaisePropertyChanged("scoreinstrument");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-device")]
        public mididevice mididevice
        {
            get
            {
                return this.midideviceField;
            }
            set
            {
                this.midideviceField = value;
                this.RaisePropertyChanged("mididevice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-instrument")]
        public midiinstrument[] midiinstrument
        {
            get
            {
                return this.midiinstrumentField;
            }
            set
            {
                this.midiinstrumentField = value;
                this.RaisePropertyChanged("midiinstrument");
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