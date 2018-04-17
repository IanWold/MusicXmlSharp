
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-list")]
    public partial class partlist : object, System.ComponentModel.INotifyPropertyChanged
    {

        private partgroup[] partgroupField;

        private scorepart scorepartField;

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-group", Order = 0)]
        public partgroup[] partgroup
        {
            get
            {
                return this.partgroupField;
            }
            set
            {
                this.partgroupField = value;
                this.RaisePropertyChanged("partgroup");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("score-part", Order = 1)]
        public scorepart scorepart
        {
            get
            {
                return this.scorepartField;
            }
            set
            {
                this.scorepartField = value;
                this.RaisePropertyChanged("scorepart");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-group", typeof(partgroup), Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute("score-part", typeof(scorepart), Order = 2)]
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