
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class accidental : object, System.ComponentModel.INotifyPropertyChanged
    {

        private yesno cautionaryField;

        private bool cautionaryFieldSpecified;

        private yesno editorialField;

        private bool editorialFieldSpecified;

        private yesno parenthesesField;

        private bool parenthesesFieldSpecified;

        private yesno bracketField;

        private bool bracketFieldSpecified;

        private symbolsize sizeField;

        private bool sizeFieldSpecified;

        private accidentalvalue valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno cautionary
        {
            get
            {
                return this.cautionaryField;
            }
            set
            {
                this.cautionaryField = value;
                this.RaisePropertyChanged("cautionary");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cautionarySpecified
        {
            get
            {
                return this.cautionaryFieldSpecified;
            }
            set
            {
                this.cautionaryFieldSpecified = value;
                this.RaisePropertyChanged("cautionarySpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno editorial
        {
            get
            {
                return this.editorialField;
            }
            set
            {
                this.editorialField = value;
                this.RaisePropertyChanged("editorial");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool editorialSpecified
        {
            get
            {
                return this.editorialFieldSpecified;
            }
            set
            {
                this.editorialFieldSpecified = value;
                this.RaisePropertyChanged("editorialSpecified");
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesno bracket
        {
            get
            {
                return this.bracketField;
            }
            set
            {
                this.bracketField = value;
                this.RaisePropertyChanged("bracket");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bracketSpecified
        {
            get
            {
                return this.bracketFieldSpecified;
            }
            set
            {
                this.bracketFieldSpecified = value;
                this.RaisePropertyChanged("bracketSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public symbolsize size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
                this.RaisePropertyChanged("size");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified
        {
            get
            {
                return this.sizeFieldSpecified;
            }
            set
            {
                this.sizeFieldSpecified = value;
                this.RaisePropertyChanged("sizeSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public accidentalvalue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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