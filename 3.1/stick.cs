
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class stick : object, System.ComponentModel.INotifyPropertyChanged
    {

        private sticktype sticktypeField;

        private stickmaterial stickmaterialField;

        private tipdirection tipField;

        private bool tipFieldSpecified;

        private yesno parenthesesField;

        private bool parenthesesFieldSpecified;

        private yesno dashedcircleField;

        private bool dashedcircleFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stick-type")]
        public sticktype sticktype
        {
            get
            {
                return this.sticktypeField;
            }
            set
            {
                this.sticktypeField = value;
                this.RaisePropertyChanged("sticktype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stick-material")]
        public stickmaterial stickmaterial
        {
            get
            {
                return this.stickmaterialField;
            }
            set
            {
                this.stickmaterialField = value;
                this.RaisePropertyChanged("stickmaterial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public tipdirection tip
        {
            get
            {
                return this.tipField;
            }
            set
            {
                this.tipField = value;
                this.RaisePropertyChanged("tip");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipSpecified
        {
            get
            {
                return this.tipFieldSpecified;
            }
            set
            {
                this.tipFieldSpecified = value;
                this.RaisePropertyChanged("tipSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno parentheses
        {
            get
            {
                return this.parenthesesField;
            }
            set
            {
                this.parenthesesField = value;
                this.RaisePropertyChanged("parentheses");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parenthesesSpecified
        {
            get
            {
                return this.parenthesesFieldSpecified;
            }
            set
            {
                this.parenthesesFieldSpecified = value;
                this.RaisePropertyChanged("parenthesesSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dashed-circle")]
        public yesno dashedcircle
        {
            get
            {
                return this.dashedcircleField;
            }
            set
            {
                this.dashedcircleField = value;
                this.RaisePropertyChanged("dashedcircle");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dashedcircleSpecified
        {
            get
            {
                return this.dashedcircleFieldSpecified;
            }
            set
            {
                this.dashedcircleFieldSpecified = value;
                this.RaisePropertyChanged("dashedcircleSpecified");
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