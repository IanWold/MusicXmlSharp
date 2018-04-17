
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "lyric-font")]
    public partial class lyricfont : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string numberField;

        private string nameField;

        private string fontfamilyField;

        private fontstyle fontstyleField;

        private bool fontstyleFieldSpecified;

        private string fontsizeField;

        private fontweight fontweightField;

        private bool fontweightFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
                this.RaisePropertyChanged("number");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("name");
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