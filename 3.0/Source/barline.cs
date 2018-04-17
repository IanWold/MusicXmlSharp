
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class barline : object, System.ComponentModel.INotifyPropertyChanged
    {

        private barstylecolor barstyleField;

        private formattedtext footnoteField;

        private level levelField;

        private wavyline wavylineField;

        private emptyprintstylealign segnoField;

        private emptyprintstylealign codaField;

        private fermata[] fermataField;

        private ending endingField;

        private repeat repeatField;

        private rightleftmiddle locationField;

        private string segno1Field;

        private string coda1Field;

        private decimal divisionsField;

        private bool divisionsFieldSpecified;

        public barline()
        {
            this.locationField = rightleftmiddle.right;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bar-style")]
        public barstylecolor barstyle
        {
            get
            {
                return this.barstyleField;
            }
            set
            {
                this.barstyleField = value;
                this.RaisePropertyChanged("barstyle");
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
        [System.Xml.Serialization.XmlElementAttribute("wavy-line")]
        public wavyline wavyline
        {
            get
            {
                return this.wavylineField;
            }
            set
            {
                this.wavylineField = value;
                this.RaisePropertyChanged("wavyline");
            }
        }

        /// <remarks/>
        public emptyprintstylealign segno
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
        public emptyprintstylealign coda
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
        [System.Xml.Serialization.XmlElementAttribute("fermata")]
        public fermata[] fermata
        {
            get
            {
                return this.fermataField;
            }
            set
            {
                this.fermataField = value;
                this.RaisePropertyChanged("fermata");
            }
        }

        /// <remarks/>
        public ending ending
        {
            get
            {
                return this.endingField;
            }
            set
            {
                this.endingField = value;
                this.RaisePropertyChanged("ending");
            }
        }

        /// <remarks/>
        public repeat repeat
        {
            get
            {
                return this.repeatField;
            }
            set
            {
                this.repeatField = value;
                this.RaisePropertyChanged("repeat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(rightleftmiddle.right)]
        public rightleftmiddle location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("segno", DataType = "token")]
        public string segno1
        {
            get
            {
                return this.segno1Field;
            }
            set
            {
                this.segno1Field = value;
                this.RaisePropertyChanged("segno1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("coda", DataType = "token")]
        public string coda1
        {
            get
            {
                return this.coda1Field;
            }
            set
            {
                this.coda1Field = value;
                this.RaisePropertyChanged("coda1");
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