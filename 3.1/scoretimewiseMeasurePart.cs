
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class scoretimewiseMeasurePart : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(attributes))]
        [System.Xml.Serialization.XmlElementAttribute("backup", typeof(backup))]
        [System.Xml.Serialization.XmlElementAttribute("barline", typeof(barline))]
        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(bookmark))]
        [System.Xml.Serialization.XmlElementAttribute("direction", typeof(direction))]
        [System.Xml.Serialization.XmlElementAttribute("figured-bass", typeof(figuredbass))]
        [System.Xml.Serialization.XmlElementAttribute("forward", typeof(forward))]
        [System.Xml.Serialization.XmlElementAttribute("grouping", typeof(grouping))]
        [System.Xml.Serialization.XmlElementAttribute("harmony", typeof(harmony))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(link))]
        [System.Xml.Serialization.XmlElementAttribute("note", typeof(note))]
        [System.Xml.Serialization.XmlElementAttribute("print", typeof(print))]
        [System.Xml.Serialization.XmlElementAttribute("sound", typeof(sound))]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
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