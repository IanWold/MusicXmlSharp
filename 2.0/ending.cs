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
    public partial class ending : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string numberField;

        private startstopdiscontinue typeField;

        private yesno printobjectField;

        private bool printobjectFieldSpecified;

        private decimal endlengthField;

        private bool endlengthFieldSpecified;

        private decimal textxField;

        private bool textxFieldSpecified;

        private decimal textyField;

        private bool textyFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
                this.RaisePropertyChanged("number");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public startstopdiscontinue type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("type");
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("end-length")]
        public decimal endlength
        {
            get
            {
                return this.endlengthField;
            }
            set
            {
                this.endlengthField = value;
                this.RaisePropertyChanged("endlength");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endlengthSpecified
        {
            get
            {
                return this.endlengthFieldSpecified;
            }
            set
            {
                this.endlengthFieldSpecified = value;
                this.RaisePropertyChanged("endlengthSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("text-x")]
        public decimal textx
        {
            get
            {
                return this.textxField;
            }
            set
            {
                this.textxField = value;
                this.RaisePropertyChanged("textx");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool textxSpecified
        {
            get
            {
                return this.textxFieldSpecified;
            }
            set
            {
                this.textxFieldSpecified = value;
                this.RaisePropertyChanged("textxSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("text-y")]
        public decimal texty
        {
            get
            {
                return this.textyField;
            }
            set
            {
                this.textyField = value;
                this.RaisePropertyChanged("texty");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool textySpecified
        {
            get
            {
                return this.textyFieldSpecified;
            }
            set
            {
                this.textyFieldSpecified = value;
                this.RaisePropertyChanged("textySpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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