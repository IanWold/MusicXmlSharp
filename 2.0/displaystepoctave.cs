
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "display-step-octave")]
    public partial class displaystepoctave : object, System.ComponentModel.INotifyPropertyChanged
    {

        private step displaystepField;

        private string displayoctaveField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("display-step")]
        public step displaystep
        {
            get
            {
                return this.displaystepField;
            }
            set
            {
                this.displaystepField = value;
                this.RaisePropertyChanged("displaystep");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("display-octave", DataType = "integer")]
        public string displayoctave
        {
            get
            {
                return this.displayoctaveField;
            }
            set
            {
                this.displayoctaveField = value;
                this.RaisePropertyChanged("displayoctave");
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