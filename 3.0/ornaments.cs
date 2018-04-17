
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ornaments : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private accidentalmark[] accidentalmarkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("delayed-inverted-turn", typeof(horizontalturn))]
        [System.Xml.Serialization.XmlElementAttribute("delayed-turn", typeof(horizontalturn))]
        [System.Xml.Serialization.XmlElementAttribute("inverted-mordent", typeof(mordent))]
        [System.Xml.Serialization.XmlElementAttribute("inverted-turn", typeof(horizontalturn))]
        [System.Xml.Serialization.XmlElementAttribute("mordent", typeof(mordent))]
        [System.Xml.Serialization.XmlElementAttribute("other-ornament", typeof(placementtext))]
        [System.Xml.Serialization.XmlElementAttribute("schleifer", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("shake", typeof(emptytrillsound))]
        [System.Xml.Serialization.XmlElementAttribute("tremolo", typeof(tremolo))]
        [System.Xml.Serialization.XmlElementAttribute("trill-mark", typeof(emptytrillsound))]
        [System.Xml.Serialization.XmlElementAttribute("turn", typeof(horizontalturn))]
        [System.Xml.Serialization.XmlElementAttribute("vertical-turn", typeof(emptytrillsound))]
        [System.Xml.Serialization.XmlElementAttribute("wavy-line", typeof(wavyline))]
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
        public ItemsChoiceType2[] ItemsElementName
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
        [System.Xml.Serialization.XmlElementAttribute("accidental-mark")]
        public accidentalmark[] accidentalmark
        {
            get
            {
                return this.accidentalmarkField;
            }
            set
            {
                this.accidentalmarkField = value;
                this.RaisePropertyChanged("accidentalmark");
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