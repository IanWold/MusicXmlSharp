
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("score-partwise", Namespace = "", IsNullable = false)]
    public partial class scorepartwise : object, System.ComponentModel.INotifyPropertyChanged
    {

        private work workField;

        private string movementnumberField;

        private string movementtitleField;

        private identification identificationField;

        private defaults defaultsField;

        private credit[] creditField;

        private partlist partlistField;

        private scorepartwisePart[] partField;

        private string versionField;

        public scorepartwise()
        {
            this.versionField = "1.0";
        }

        /// <remarks/>
        public work work
        {
            get
            {
                return this.workField;
            }
            set
            {
                this.workField = value;
                this.RaisePropertyChanged("work");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("movement-number")]
        public string movementnumber
        {
            get
            {
                return this.movementnumberField;
            }
            set
            {
                this.movementnumberField = value;
                this.RaisePropertyChanged("movementnumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("movement-title")]
        public string movementtitle
        {
            get
            {
                return this.movementtitleField;
            }
            set
            {
                this.movementtitleField = value;
                this.RaisePropertyChanged("movementtitle");
            }
        }

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
        public defaults defaults
        {
            get
            {
                return this.defaultsField;
            }
            set
            {
                this.defaultsField = value;
                this.RaisePropertyChanged("defaults");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("credit")]
        public credit[] credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
                this.RaisePropertyChanged("credit");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-list")]
        public partlist partlist
        {
            get
            {
                return this.partlistField;
            }
            set
            {
                this.partlistField = value;
                this.RaisePropertyChanged("partlist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part")]
        public scorepartwisePart[] part
        {
            get
            {
                return this.partField;
            }
            set
            {
                this.partField = value;
                this.RaisePropertyChanged("part");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("1.0")]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
                this.RaisePropertyChanged("version");
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