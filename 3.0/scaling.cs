
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class scaling : object, System.ComponentModel.INotifyPropertyChanged
    {

        private decimal millimetersField;

        private decimal tenthsField;

        /// <remarks/>
        public decimal millimeters
        {
            get
            {
                return this.millimetersField;
            }
            set
            {
                this.millimetersField = value;
                this.RaisePropertyChanged("millimeters");
            }
        }

        /// <remarks/>
        public decimal tenths
        {
            get
            {
                return this.tenthsField;
            }
            set
            {
                this.tenthsField = value;
                this.RaisePropertyChanged("tenths");
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