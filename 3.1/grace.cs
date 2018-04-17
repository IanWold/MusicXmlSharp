
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class grace : object, System.ComponentModel.INotifyPropertyChanged
    {

        private decimal stealtimepreviousField;

        private bool stealtimepreviousFieldSpecified;

        private decimal stealtimefollowingField;

        private bool stealtimefollowingFieldSpecified;

        private decimal maketimeField;

        private bool maketimeFieldSpecified;

        private yesno slashField;

        private bool slashFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("steal-time-previous")]
        public decimal stealtimeprevious
        {
            get
            {
                return this.stealtimepreviousField;
            }
            set
            {
                this.stealtimepreviousField = value;
                this.RaisePropertyChanged("stealtimeprevious");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stealtimepreviousSpecified
        {
            get
            {
                return this.stealtimepreviousFieldSpecified;
            }
            set
            {
                this.stealtimepreviousFieldSpecified = value;
                this.RaisePropertyChanged("stealtimepreviousSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("steal-time-following")]
        public decimal stealtimefollowing
        {
            get
            {
                return this.stealtimefollowingField;
            }
            set
            {
                this.stealtimefollowingField = value;
                this.RaisePropertyChanged("stealtimefollowing");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stealtimefollowingSpecified
        {
            get
            {
                return this.stealtimefollowingFieldSpecified;
            }
            set
            {
                this.stealtimefollowingFieldSpecified = value;
                this.RaisePropertyChanged("stealtimefollowingSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("make-time")]
        public decimal maketime
        {
            get
            {
                return this.maketimeField;
            }
            set
            {
                this.maketimeField = value;
                this.RaisePropertyChanged("maketime");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maketimeSpecified
        {
            get
            {
                return this.maketimeFieldSpecified;
            }
            set
            {
                this.maketimeFieldSpecified = value;
                this.RaisePropertyChanged("maketimeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno slash
        {
            get
            {
                return this.slashField;
            }
            set
            {
                this.slashField = value;
                this.RaisePropertyChanged("slash");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool slashSpecified
        {
            get
            {
                return this.slashFieldSpecified;
            }
            set
            {
                this.slashFieldSpecified = value;
                this.RaisePropertyChanged("slashSpecified");
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