
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class scordatura : object, System.ComponentModel.INotifyPropertyChanged
    {

        private accord[] accordField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accord")]
        public accord[] accord
        {
            get
            {
                return this.accordField;
            }
            set
            {
                this.accordField = value;
                this.RaisePropertyChanged("accord");
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