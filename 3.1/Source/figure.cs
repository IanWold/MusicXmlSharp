
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class figure : object, System.ComponentModel.INotifyPropertyChanged
    {

        private styletext prefixField;

        private styletext figurenumberField;

        private styletext suffixField;

        private extend extendField;

        private formattedtext footnoteField;

        private level levelField;

        /// <remarks/>
        public styletext prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
                this.RaisePropertyChanged("prefix");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("figure-number")]
        public styletext figurenumber
        {
            get
            {
                return this.figurenumberField;
            }
            set
            {
                this.figurenumberField = value;
                this.RaisePropertyChanged("figurenumber");
            }
        }

        /// <remarks/>
        public styletext suffix
        {
            get
            {
                return this.suffixField;
            }
            set
            {
                this.suffixField = value;
                this.RaisePropertyChanged("suffix");
            }
        }

        /// <remarks/>
        public extend extend
        {
            get
            {
                return this.extendField;
            }
            set
            {
                this.extendField = value;
                this.RaisePropertyChanged("extend");
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