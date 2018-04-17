
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class root : object, System.ComponentModel.INotifyPropertyChanged
    {

        private rootstep rootstepField;

        private rootalter rootalterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("root-step")]
        public rootstep rootstep
        {
            get
            {
                return this.rootstepField;
            }
            set
            {
                this.rootstepField = value;
                this.RaisePropertyChanged("rootstep");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("root-alter")]
        public rootalter rootalter
        {
            get
            {
                return this.rootalterField;
            }
            set
            {
                this.rootalterField = value;
                this.RaisePropertyChanged("rootalter");
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