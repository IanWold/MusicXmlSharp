
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class note : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        private instrument instrumentField;

        private formattedtext footnoteField;

        private level levelField;

        private string voiceField;

        private notetype typeField;

        private emptyplacement[] dotField;

        private accidental accidentalField;

        private timemodification timemodificationField;

        private stem stemField;

        private notehead noteheadField;

        private noteheadtext noteheadtextField;

        private string staffField;

        private beam[] beamField;

        private notations[] notationsField;

        private lyric[] lyricField;

        private play playField;

        private decimal defaultxField;

        private bool defaultxFieldSpecified;

        private decimal defaultyField;

        private bool defaultyFieldSpecified;

        private decimal relativexField;

        private bool relativexFieldSpecified;

        private decimal relativeyField;

        private bool relativeyFieldSpecified;

        private string fontfamilyField;

        private fontstyle fontstyleField;

        private bool fontstyleFieldSpecified;

        private string fontsizeField;

        private fontweight fontweightField;

        private bool fontweightFieldSpecified;

        private string colorField;

        private yesno printdotField;

        private bool printdotFieldSpecified;

        private yesno printlyricField;

        private bool printlyricFieldSpecified;

        private yesno printlegerField;

        private bool printlegerFieldSpecified;

        private decimal dynamicsField;

        private bool dynamicsFieldSpecified;

        private decimal enddynamicsField;

        private bool enddynamicsFieldSpecified;

        private decimal attackField;

        private bool attackFieldSpecified;

        private decimal releaseField;

        private bool releaseFieldSpecified;

        private string timeonlyField;

        private yesno pizzicatoField;

        private bool pizzicatoFieldSpecified;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("chord", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("cue", typeof(empty))]
        [System.Xml.Serialization.XmlElementAttribute("duration", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("grace", typeof(grace))]
        [System.Xml.Serialization.XmlElementAttribute("pitch", typeof(pitch))]
        [System.Xml.Serialization.XmlElementAttribute("rest", typeof(rest))]
        [System.Xml.Serialization.XmlElementAttribute("tie", typeof(tie))]
        [System.Xml.Serialization.XmlElementAttribute("unpitched", typeof(unpitched))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
                this.RaisePropertyChanged("ItemsElementName");
            }
        }

        /// <remarks/>
        public instrument instrument
        {
            get
            {
                return this.instrumentField;
            }
            set
            {
                this.instrumentField = value;
                this.RaisePropertyChanged("instrument");
            }
        }

        /// <remarks/>
        public formattedtext footnote
        {
            get
            {
                return this.footnoteField;
            }
            set
            {
                this.footnoteField = value;
                this.RaisePropertyChanged("footnote");
            }
        }

        /// <remarks/>
        public level level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
                this.RaisePropertyChanged("level");
            }
        }

        /// <remarks/>
        public string voice
        {
            get
            {
                return this.voiceField;
            }
            set
            {
                this.voiceField = value;
                this.RaisePropertyChanged("voice");
            }
        }

        /// <remarks/>
        public notetype type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dot")]
        public emptyplacement[] dot
        {
            get
            {
                return this.dotField;
            }
            set
            {
                this.dotField = value;
                this.RaisePropertyChanged("dot");
            }
        }

        /// <remarks/>
        public accidental accidental
        {
            get
            {
                return this.accidentalField;
            }
            set
            {
                this.accidentalField = value;
                this.RaisePropertyChanged("accidental");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time-modification")]
        public timemodification timemodification
        {
            get
            {
                return this.timemodificationField;
            }
            set
            {
                this.timemodificationField = value;
                this.RaisePropertyChanged("timemodification");
            }
        }

        /// <remarks/>
        public stem stem
        {
            get
            {
                return this.stemField;
            }
            set
            {
                this.stemField = value;
                this.RaisePropertyChanged("stem");
            }
        }

        /// <remarks/>
        public notehead notehead
        {
            get
            {
                return this.noteheadField;
            }
            set
            {
                this.noteheadField = value;
                this.RaisePropertyChanged("notehead");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("notehead-text")]
        public noteheadtext noteheadtext
        {
            get
            {
                return this.noteheadtextField;
            }
            set
            {
                this.noteheadtextField = value;
                this.RaisePropertyChanged("noteheadtext");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string staff
        {
            get
            {
                return this.staffField;
            }
            set
            {
                this.staffField = value;
                this.RaisePropertyChanged("staff");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("beam")]
        public beam[] beam
        {
            get
            {
                return this.beamField;
            }
            set
            {
                this.beamField = value;
                this.RaisePropertyChanged("beam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("notations")]
        public notations[] notations
        {
            get
            {
                return this.notationsField;
            }
            set
            {
                this.notationsField = value;
                this.RaisePropertyChanged("notations");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lyric")]
        public lyric[] lyric
        {
            get
            {
                return this.lyricField;
            }
            set
            {
                this.lyricField = value;
                this.RaisePropertyChanged("lyric");
            }
        }

        /// <remarks/>
        public play play
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
        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultx
        {
            get
            {
                return this.defaultxField;
            }
            set
            {
                this.defaultxField = value;
                this.RaisePropertyChanged("defaultx");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultxSpecified
        {
            get
            {
                return this.defaultxFieldSpecified;
            }
            set
            {
                this.defaultxFieldSpecified = value;
                this.RaisePropertyChanged("defaultxSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaulty
        {
            get
            {
                return this.defaultyField;
            }
            set
            {
                this.defaultyField = value;
                this.RaisePropertyChanged("defaulty");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultySpecified
        {
            get
            {
                return this.defaultyFieldSpecified;
            }
            set
            {
                this.defaultyFieldSpecified = value;
                this.RaisePropertyChanged("defaultySpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativex
        {
            get
            {
                return this.relativexField;
            }
            set
            {
                this.relativexField = value;
                this.RaisePropertyChanged("relativex");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativexSpecified
        {
            get
            {
                return this.relativexFieldSpecified;
            }
            set
            {
                this.relativexFieldSpecified = value;
                this.RaisePropertyChanged("relativexSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativey
        {
            get
            {
                return this.relativeyField;
            }
            set
            {
                this.relativeyField = value;
                this.RaisePropertyChanged("relativey");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativeySpecified
        {
            get
            {
                return this.relativeyFieldSpecified;
            }
            set
            {
                this.relativeyFieldSpecified = value;
                this.RaisePropertyChanged("relativeySpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontfamily
        {
            get
            {
                return this.fontfamilyField;
            }
            set
            {
                this.fontfamilyField = value;
                this.RaisePropertyChanged("fontfamily");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public fontstyle fontstyle
        {
            get
            {
                return this.fontstyleField;
            }
            set
            {
                this.fontstyleField = value;
                this.RaisePropertyChanged("fontstyle");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontstyleSpecified
        {
            get
            {
                return this.fontstyleFieldSpecified;
            }
            set
            {
                this.fontstyleFieldSpecified = value;
                this.RaisePropertyChanged("fontstyleSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontsize
        {
            get
            {
                return this.fontsizeField;
            }
            set
            {
                this.fontsizeField = value;
                this.RaisePropertyChanged("fontsize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public fontweight fontweight
        {
            get
            {
                return this.fontweightField;
            }
            set
            {
                this.fontweightField = value;
                this.RaisePropertyChanged("fontweight");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fontweightSpecified
        {
            get
            {
                return this.fontweightFieldSpecified;
            }
            set
            {
                this.fontweightFieldSpecified = value;
                this.RaisePropertyChanged("fontweightSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
                this.RaisePropertyChanged("color");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-dot")]
        public yesno printdot
        {
            get
            {
                return this.printdotField;
            }
            set
            {
                this.printdotField = value;
                this.RaisePropertyChanged("printdot");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printdotSpecified
        {
            get
            {
                return this.printdotFieldSpecified;
            }
            set
            {
                this.printdotFieldSpecified = value;
                this.RaisePropertyChanged("printdotSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-lyric")]
        public yesno printlyric
        {
            get
            {
                return this.printlyricField;
            }
            set
            {
                this.printlyricField = value;
                this.RaisePropertyChanged("printlyric");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printlyricSpecified
        {
            get
            {
                return this.printlyricFieldSpecified;
            }
            set
            {
                this.printlyricFieldSpecified = value;
                this.RaisePropertyChanged("printlyricSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-leger")]
        public yesno printleger
        {
            get
            {
                return this.printlegerField;
            }
            set
            {
                this.printlegerField = value;
                this.RaisePropertyChanged("printleger");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printlegerSpecified
        {
            get
            {
                return this.printlegerFieldSpecified;
            }
            set
            {
                this.printlegerFieldSpecified = value;
                this.RaisePropertyChanged("printlegerSpecified");
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
        [System.Xml.Serialization.XmlAttributeAttribute("end-dynamics")]
        public decimal enddynamics
        {
            get
            {
                return this.enddynamicsField;
            }
            set
            {
                this.enddynamicsField = value;
                this.RaisePropertyChanged("enddynamics");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enddynamicsSpecified
        {
            get
            {
                return this.enddynamicsFieldSpecified;
            }
            set
            {
                this.enddynamicsFieldSpecified = value;
                this.RaisePropertyChanged("enddynamicsSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal attack
        {
            get
            {
                return this.attackField;
            }
            set
            {
                this.attackField = value;
                this.RaisePropertyChanged("attack");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool attackSpecified
        {
            get
            {
                return this.attackFieldSpecified;
            }
            set
            {
                this.attackFieldSpecified = value;
                this.RaisePropertyChanged("attackSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal release
        {
            get
            {
                return this.releaseField;
            }
            set
            {
                this.releaseField = value;
                this.RaisePropertyChanged("release");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseSpecified
        {
            get
            {
                return this.releaseFieldSpecified;
            }
            set
            {
                this.releaseFieldSpecified = value;
                this.RaisePropertyChanged("releaseSpecified");
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