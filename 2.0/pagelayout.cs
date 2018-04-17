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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "page-layout")]
    public partial class pagelayout : object, System.ComponentModel.INotifyPropertyChanged
    {

        private decimal pageheightField;

        private decimal pagewidthField;

        private pagemargins[] pagemarginsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("page-height")]
        public decimal pageheight
        {
            get
            {
                return this.pageheightField;
            }
            set
            {
                this.pageheightField = value;
                this.RaisePropertyChanged("pageheight");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("page-width")]
        public decimal pagewidth
        {
            get
            {
                return this.pagewidthField;
            }
            set
            {
                this.pagewidthField = value;
                this.RaisePropertyChanged("pagewidth");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("page-margins")]
        public pagemargins[] pagemargins
        {
            get
            {
                return this.pagemarginsField;
            }
            set
            {
                this.pagemarginsField = value;
                this.RaisePropertyChanged("pagemargins");
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