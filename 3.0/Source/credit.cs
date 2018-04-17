
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class credit : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] credittypeField;

        private link[] linkField;

        private bookmark[] bookmarkField;

        private object[] itemsField;

        private string pageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("credit-type", Order = 0)]
        public string[] credittype
        {
            get
            {
                return this.credittypeField;
            }
            set
            {
                this.credittypeField = value;
                this.RaisePropertyChanged("credittype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link", Order = 1)]
        public link[] link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
                this.RaisePropertyChanged("link");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bookmark", Order = 2)]
        public bookmark[] bookmark
        {
            get
            {
                return this.bookmarkField;
            }
            set
            {
                this.bookmarkField = value;
                this.RaisePropertyChanged("bookmark");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("credit-image", typeof(image), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("credit-words", typeof(formattedtext), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(link), Order = 3)]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string page
        {
            get
            {
                return this.pageField;
            }
            set
            {
                this.pageField = value;
                this.RaisePropertyChanged("page");
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