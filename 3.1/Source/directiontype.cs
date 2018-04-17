
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "direction-type")]
    public partial class directiontype : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        private ItemsChoiceType8[] itemsElementNameField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accordion-registration", typeof(accordionregistration))]
        [System.Xml.Serialization.XmlElementAttribute("bracket", typeof(bracket))]
        [System.Xml.Serialization.XmlElementAttribute("coda", typeof(coda))]
        [System.Xml.Serialization.XmlElementAttribute("damp", typeof(emptyprintstylealignid))]
        [System.Xml.Serialization.XmlElementAttribute("damp-all", typeof(emptyprintstylealignid))]
        [System.Xml.Serialization.XmlElementAttribute("dashes", typeof(dashes))]
        [System.Xml.Serialization.XmlElementAttribute("dynamics", typeof(dynamics))]
        [System.Xml.Serialization.XmlElementAttribute("eyeglasses", typeof(emptyprintstylealignid))]
        [System.Xml.Serialization.XmlElementAttribute("harp-pedals", typeof(harppedals))]
        [System.Xml.Serialization.XmlElementAttribute("image", typeof(image))]
        [System.Xml.Serialization.XmlElementAttribute("metronome", typeof(metronome))]
        [System.Xml.Serialization.XmlElementAttribute("octave-shift", typeof(octaveshift))]
        [System.Xml.Serialization.XmlElementAttribute("other-direction", typeof(otherdirection))]
        [System.Xml.Serialization.XmlElementAttribute("pedal", typeof(pedal))]
        [System.Xml.Serialization.XmlElementAttribute("percussion", typeof(percussion))]
        [System.Xml.Serialization.XmlElementAttribute("principal-voice", typeof(principalvoice))]
        [System.Xml.Serialization.XmlElementAttribute("rehearsal", typeof(formattedtextid))]
        [System.Xml.Serialization.XmlElementAttribute("scordatura", typeof(scordatura))]
        [System.Xml.Serialization.XmlElementAttribute("segno", typeof(segno))]
        [System.Xml.Serialization.XmlElementAttribute("staff-divide", typeof(staffdivide))]
        [System.Xml.Serialization.XmlElementAttribute("string-mute", typeof(stringmute))]
        [System.Xml.Serialization.XmlElementAttribute("symbol", typeof(formattedsymbolid))]
        [System.Xml.Serialization.XmlElementAttribute("wedge", typeof(wedge))]
        [System.Xml.Serialization.XmlElementAttribute("words", typeof(formattedtextid))]
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
        public ItemsChoiceType8[] ItemsElementName
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