
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tuplet-portion")]
    public partial class tupletportion : object, System.ComponentModel.INotifyPropertyChanged
    {

        private tupletnumber tupletnumberField;

        private tuplettype tuplettypeField;

        private tupletdot[] tupletdotField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuplet-number")]
        public tupletnumber tupletnumber
        {
            get
            {
                return this.tupletnumberField;
            }
            set
            {
                this.tupletnumberField = value;
                this.RaisePropertyChanged("tupletnumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuplet-type")]
        public tuplettype tuplettype
        {
            get
            {
                return this.tuplettypeField;
            }
            set
            {
                this.tuplettypeField = value;
                this.RaisePropertyChanged("tuplettype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tuplet-dot")]
        public tupletdot[] tupletdot
        {
            get
            {
                return this.tupletdotField;
            }
            set
            {
                this.tupletdotField = value;
                this.RaisePropertyChanged("tupletdot");
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