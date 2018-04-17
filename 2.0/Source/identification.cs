
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class identification : object, System.ComponentModel.INotifyPropertyChanged
    {

        private typedtext[] creatorField;

        private typedtext[] rightsField;

        private encoding encodingField;

        private string sourceField;

        private typedtext[] relationField;

        private miscellaneousfield[] miscellaneousField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creator")]
        public typedtext[] creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
                this.RaisePropertyChanged("creator");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rights")]
        public typedtext[] rights
        {
            get
            {
                return this.rightsField;
            }
            set
            {
                this.rightsField = value;
                this.RaisePropertyChanged("rights");
            }
        }

        /// <remarks/>
        public encoding encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
                this.RaisePropertyChanged("encoding");
            }
        }

        /// <remarks/>
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
                this.RaisePropertyChanged("source");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relation")]
        public typedtext[] relation
        {
            get
            {
                return this.relationField;
            }
            set
            {
                this.relationField = value;
                this.RaisePropertyChanged("relation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public miscellaneousfield[] miscellaneous
        {
            get
            {
                return this.miscellaneousField;
            }
            set
            {
                this.miscellaneousField = value;
                this.RaisePropertyChanged("miscellaneous");
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