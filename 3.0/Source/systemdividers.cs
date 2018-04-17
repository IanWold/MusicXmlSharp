
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-dividers")]
    public partial class systemdividers : object, System.ComponentModel.INotifyPropertyChanged
    {

        private emptyprintobjectstylealign leftdividerField;

        private emptyprintobjectstylealign rightdividerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("left-divider")]
        public emptyprintobjectstylealign leftdivider
        {
            get
            {
                return this.leftdividerField;
            }
            set
            {
                this.leftdividerField = value;
                this.RaisePropertyChanged("leftdivider");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("right-divider")]
        public emptyprintobjectstylealign rightdivider
        {
            get
            {
                return this.rightdividerField;
            }
            set
            {
                this.rightdividerField = value;
                this.RaisePropertyChanged("rightdivider");
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