
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class technical : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("arrow", typeof(arrow))]
        [System.Xml.Serialization.XmlElementAttribute("bend", typeof(bend))]
        [System.Xml.Serialization.XmlElementAttribute("brass-bend", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("double-tongue", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("down-bow", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("fingering", typeof(fingering))]
        [System.Xml.Serialization.XmlElementAttribute("fingernails", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("flip", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("fret", typeof(fret))]
        [System.Xml.Serialization.XmlElementAttribute("golpe", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("half-muted", typeof(emptyplacementsmufl))]
        [System.Xml.Serialization.XmlElementAttribute("hammer-on", typeof(hammeronpulloff))]
        [System.Xml.Serialization.XmlElementAttribute("handbell", typeof(handbell))]
        [System.Xml.Serialization.XmlElementAttribute("harmon-mute", typeof(harmonmute))]
        [System.Xml.Serialization.XmlElementAttribute("harmonic", typeof(harmonic))]
        [System.Xml.Serialization.XmlElementAttribute("heel", typeof(heeltoe))]
        [System.Xml.Serialization.XmlElementAttribute("hole", typeof(hole))]
        [System.Xml.Serialization.XmlElementAttribute("open", typeof(emptyplacementsmufl))]
        [System.Xml.Serialization.XmlElementAttribute("open-string", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("other-technical", typeof(otherplacementtext))]
        [System.Xml.Serialization.XmlElementAttribute("pluck", typeof(placementtext))]
        [System.Xml.Serialization.XmlElementAttribute("pull-off", typeof(hammeronpulloff))]
        [System.Xml.Serialization.XmlElementAttribute("smear", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("snap-pizzicato", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("stopped", typeof(emptyplacementsmufl))]
        [System.Xml.Serialization.XmlElementAttribute("string", typeof(@string))]
        [System.Xml.Serialization.XmlElementAttribute("tap", typeof(tap))]
        [System.Xml.Serialization.XmlElementAttribute("thumb-position", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("toe", typeof(heeltoe))]
        [System.Xml.Serialization.XmlElementAttribute("triple-tongue", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("up-bow", typeof(emptyplacement))]
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
        public ItemsChoiceType3[] ItemsElementName
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("id");
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