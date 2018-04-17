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
    public partial class work : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string worknumberField;

        private string worktitleField;

        private opus opusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("work-number")]
        public string worknumber
        {
            get
            {
                return this.worknumberField;
            }
            set
            {
                this.worknumberField = value;
                this.RaisePropertyChanged("worknumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("work-title")]
        public string worktitle
        {
            get
            {
                return this.worktitleField;
            }
            set
            {
                this.worktitleField = value;
                this.RaisePropertyChanged("worktitle");
            }
        }

        /// <remarks/>
        public opus opus
        {
            get
            {
                return this.opusField;
            }
            set
            {
                this.opusField = value;
                this.RaisePropertyChanged("opus");
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