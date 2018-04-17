
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class bass : object, System.ComponentModel.INotifyPropertyChanged
    {

        private bassstep bassstepField;

        private bassalter bassalterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bass-step")]
        public bassstep bassstep
        {
            get
            {
                return this.bassstepField;
            }
            set
            {
                this.bassstepField = value;
                this.RaisePropertyChanged("bassstep");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bass-alter")]
        public bassalter bassalter
        {
            get
            {
                return this.bassalterField;
            }
            set
            {
                this.bassalterField = value;
                this.RaisePropertyChanged("bassalter");
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