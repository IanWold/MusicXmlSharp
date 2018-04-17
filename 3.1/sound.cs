
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sound : object, System.ComponentModel.INotifyPropertyChanged
    {

        private mididevice[] midideviceField;

        private midiinstrument[] midiinstrumentField;

        private play[] playField;

        private offset offsetField;

        private decimal tempoField;

        private bool tempoFieldSpecified;

        private decimal dynamicsField;

        private bool dynamicsFieldSpecified;

        private yesno dacapoField;

        private bool dacapoFieldSpecified;

        private string segnoField;

        private string dalsegnoField;

        private string codaField;

        private string tocodaField;

        private decimal divisionsField;

        private bool divisionsFieldSpecified;

        private yesno forwardrepeatField;

        private bool forwardrepeatFieldSpecified;

        private string fineField;

        private string timeonlyField;

        private yesno pizzicatoField;

        private bool pizzicatoFieldSpecified;

        private decimal panField;

        private bool panFieldSpecified;

        private decimal elevationField;

        private bool elevationFieldSpecified;

        private string damperpedalField;

        private string softpedalField;

        private string sostenutopedalField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("midi-device")]
        public mididevice[] mididevice
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
        [System.Xml.Serialization.XmlElementAttribute("play")]
        public play[] play
        {
            get
            {
                return this.playField;
            }
            set
            {
                this.playField = value;
                this.RaisePropertyChanged("play");
            }
        }

        /// <remarks/>
        public offset offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
                this.RaisePropertyChanged("offset");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tempo
        {
            get
            {
                return this.tempoField;
            }
            set
            {
                this.tempoField = value;
                this.RaisePropertyChanged("tempo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tempoSpecified
        {
            get
            {
                return this.tempoFieldSpecified;
            }
            set
            {
                this.tempoFieldSpecified = value;
                this.RaisePropertyChanged("tempoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal dynamics
        {
            get
            {
                return this.dynamicsField;
            }
            set
            {
                this.dynamicsField = value;
                this.RaisePropertyChanged("dynamics");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dynamicsSpecified
        {
            get
            {
                return this.dynamicsFieldSpecified;
            }
            set
            {
                this.dynamicsFieldSpecified = value;
                this.RaisePropertyChanged("dynamicsSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno dacapo
        {
            get
            {
                return this.dacapoField;
            }
            set
            {
                this.dacapoField = value;
                this.RaisePropertyChanged("dacapo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dacapoSpecified
        {
            get
            {
                return this.dacapoFieldSpecified;
            }
            set
            {
                this.dacapoFieldSpecified = value;
                this.RaisePropertyChanged("dacapoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string segno
        {
            get
            {
                return this.segnoField;
            }
            set
            {
                this.segnoField = value;
                this.RaisePropertyChanged("segno");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string dalsegno
        {
            get
            {
                return this.dalsegnoField;
            }
            set
            {
                this.dalsegnoField = value;
                this.RaisePropertyChanged("dalsegno");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string coda
        {
            get
            {
                return this.codaField;
            }
            set
            {
                this.codaField = value;
                this.RaisePropertyChanged("coda");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string tocoda
        {
            get
            {
                return this.tocodaField;
            }
            set
            {
                this.tocodaField = value;
                this.RaisePropertyChanged("tocoda");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal divisions
        {
            get
            {
                return this.divisionsField;
            }
            set
            {
                this.divisionsField = value;
                this.RaisePropertyChanged("divisions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool divisionsSpecified
        {
            get
            {
                return this.divisionsFieldSpecified;
            }
            set
            {
                this.divisionsFieldSpecified = value;
                this.RaisePropertyChanged("divisionsSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("forward-repeat")]
        public yesno forwardrepeat
        {
            get
            {
                return this.forwardrepeatField;
            }
            set
            {
                this.forwardrepeatField = value;
                this.RaisePropertyChanged("forwardrepeat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool forwardrepeatSpecified
        {
            get
            {
                return this.forwardrepeatFieldSpecified;
            }
            set
            {
                this.forwardrepeatFieldSpecified = value;
                this.RaisePropertyChanged("forwardrepeatSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string fine
        {
            get
            {
                return this.fineField;
            }
            set
            {
                this.fineField = value;
                this.RaisePropertyChanged("fine");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("time-only", DataType = "token")]
        public string timeonly
        {
            get
            {
                return this.timeonlyField;
            }
            set
            {
                this.timeonlyField = value;
                this.RaisePropertyChanged("timeonly");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno pizzicato
        {
            get
            {
                return this.pizzicatoField;
            }
            set
            {
                this.pizzicatoField = value;
                this.RaisePropertyChanged("pizzicato");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pizzicatoSpecified
        {
            get
            {
                return this.pizzicatoFieldSpecified;
            }
            set
            {
                this.pizzicatoFieldSpecified = value;
                this.RaisePropertyChanged("pizzicatoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal pan
        {
            get
            {
                return this.panField;
            }
            set
            {
                this.panField = value;
                this.RaisePropertyChanged("pan");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool panSpecified
        {
            get
            {
                return this.panFieldSpecified;
            }
            set
            {
                this.panFieldSpecified = value;
                this.RaisePropertyChanged("panSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal elevation
        {
            get
            {
                return this.elevationField;
            }
            set
            {
                this.elevationField = value;
                this.RaisePropertyChanged("elevation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool elevationSpecified
        {
            get
            {
                return this.elevationFieldSpecified;
            }
            set
            {
                this.elevationFieldSpecified = value;
                this.RaisePropertyChanged("elevationSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("damper-pedal")]
        public string damperpedal
        {
            get
            {
                return this.damperpedalField;
            }
            set
            {
                this.damperpedalField = value;
                this.RaisePropertyChanged("damperpedal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("soft-pedal")]
        public string softpedal
        {
            get
            {
                return this.softpedalField;
            }
            set
            {
                this.softpedalField = value;
                this.RaisePropertyChanged("softpedal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("sostenuto-pedal")]
        public string sostenutopedal
        {
            get
            {
                return this.sostenutopedalField;
            }
            set
            {
                this.sostenutopedalField = value;
                this.RaisePropertyChanged("sostenutopedal");
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