using System;
using System.Linq;
using System.Collections.Generic;

namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-layout")]
    public partial class systemlayout : object, System.ComponentModel.INotifyPropertyChanged
    {

        private systemmargins systemmarginsField;

        private decimal systemdistanceField;

        private bool systemdistanceFieldSpecified;

        private decimal topsystemdistanceField;

        private bool topsystemdistanceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("system-margins")]
        public systemmargins systemmargins
        {
            get
            {
                return this.systemmarginsField;
            }
            set
            {
                this.systemmarginsField = value;
                this.RaisePropertyChanged("systemmargins");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("system-distance")]
        public decimal systemdistance
        {
            get
            {
                return this.systemdistanceField;
            }
            set
            {
                this.systemdistanceField = value;
                this.RaisePropertyChanged("systemdistance");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool systemdistanceSpecified
        {
            get
            {
                return this.systemdistanceFieldSpecified;
            }
            set
            {
                this.systemdistanceFieldSpecified = value;
                this.RaisePropertyChanged("systemdistanceSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("top-system-distance")]
        public decimal topsystemdistance
        {
            get
            {
                return this.topsystemdistanceField;
            }
            set
            {
                this.topsystemdistanceField = value;
                this.RaisePropertyChanged("topsystemdistance");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool topsystemdistanceSpecified
        {
            get
            {
                return this.topsystemdistanceFieldSpecified;
            }
            set
            {
                this.topsystemdistanceFieldSpecified = value;
                this.RaisePropertyChanged("topsystemdistanceSpecified");
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