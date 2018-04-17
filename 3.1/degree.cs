
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class degree : object, System.ComponentModel.INotifyPropertyChanged
    {

        private degreevalue degreevalueField;

        private degreealter degreealterField;

        private degreetype degreetypeField;

        private yesno printobjectField;

        private bool printobjectFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("degree-value")]
        public degreevalue degreevalue
        {
            get
            {
                return this.degreevalueField;
            }
            set
            {
                this.degreevalueField = value;
                this.RaisePropertyChanged("degreevalue");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("degree-alter")]
        public degreealter degreealter
        {
            get
            {
                return this.degreealterField;
            }
            set
            {
                this.degreealterField = value;
                this.RaisePropertyChanged("degreealter");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("degree-type")]
        public degreetype degreetype
        {
            get
            {
                return this.degreetypeField;
            }
            set
            {
                this.degreetypeField = value;
                this.RaisePropertyChanged("degreetype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public yesno printobject
        {
            get
            {
                return this.printobjectField;
            }
            set
            {
                this.printobjectField = value;
                this.RaisePropertyChanged("printobject");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printobjectSpecified
        {
            get
            {
                return this.printobjectFieldSpecified;
            }
            set
            {
                this.printobjectFieldSpecified = value;
                this.RaisePropertyChanged("printobjectSpecified");
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