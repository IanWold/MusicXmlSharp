
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "measure-layout")]
    public partial class measurelayout : object, System.ComponentModel.INotifyPropertyChanged
    {

        private decimal measuredistanceField;

        private bool measuredistanceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("measure-distance")]
        public decimal measuredistance
        {
            get
            {
                return this.measuredistanceField;
            }
            set
            {
                this.measuredistanceField = value;
                this.RaisePropertyChanged("measuredistance");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measuredistanceSpecified
        {
            get
            {
                return this.measuredistanceFieldSpecified;
            }
            set
            {
                this.measuredistanceFieldSpecified = value;
                this.RaisePropertyChanged("measuredistanceSpecified");
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