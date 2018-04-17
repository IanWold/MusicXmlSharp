
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class articulations : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        private ItemsChoiceType4[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accent", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("breath-mark", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("caesura", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("detached-legato", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("doit", typeof(emptyline))]
        [System.Xml.Serialization.XmlElementAttribute("falloff", typeof(emptyline))]
        [System.Xml.Serialization.XmlElementAttribute("other-articulation", typeof(placementtext))]
        [System.Xml.Serialization.XmlElementAttribute("plop", typeof(emptyline))]
        [System.Xml.Serialization.XmlElementAttribute("scoop", typeof(emptyline))]
        [System.Xml.Serialization.XmlElementAttribute("spiccato", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("staccatissimo", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("staccato", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("stress", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("strong-accent", typeof(strongaccent))]
        [System.Xml.Serialization.XmlElementAttribute("tenuto", typeof(emptyplacement))]
        [System.Xml.Serialization.XmlElementAttribute("unstress", typeof(emptyplacement))]
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
        public ItemsChoiceType4[] ItemsElementName
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