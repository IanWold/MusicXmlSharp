
namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class print : object, System.ComponentModel.INotifyPropertyChanged
    {

        private pagelayout pagelayoutField;

        private systemlayout systemlayoutField;

        private stafflayout[] stafflayoutField;

        private measurelayout measurelayoutField;

        private measurenumbering measurenumberingField;

        private namedisplay partnamedisplayField;

        private namedisplay partabbreviationdisplayField;

        private decimal staffspacingField;

        private bool staffspacingFieldSpecified;

        private yesno newsystemField;

        private bool newsystemFieldSpecified;

        private yesno newpageField;

        private bool newpageFieldSpecified;

        private string blankpageField;

        private string pagenumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("page-layout")]
        public pagelayout pagelayout
        {
            get
            {
                return this.pagelayoutField;
            }
            set
            {
                this.pagelayoutField = value;
                this.RaisePropertyChanged("pagelayout");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("system-layout")]
        public systemlayout systemlayout
        {
            get
            {
                return this.systemlayoutField;
            }
            set
            {
                this.systemlayoutField = value;
                this.RaisePropertyChanged("systemlayout");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff-layout")]
        public stafflayout[] stafflayout
        {
            get
            {
                return this.stafflayoutField;
            }
            set
            {
                this.stafflayoutField = value;
                this.RaisePropertyChanged("stafflayout");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("measure-layout")]
        public measurelayout measurelayout
        {
            get
            {
                return this.measurelayoutField;
            }
            set
            {
                this.measurelayoutField = value;
                this.RaisePropertyChanged("measurelayout");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("measure-numbering")]
        public measurenumbering measurenumbering
        {
            get
            {
                return this.measurenumberingField;
            }
            set
            {
                this.measurenumberingField = value;
                this.RaisePropertyChanged("measurenumbering");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-name-display")]
        public namedisplay partnamedisplay
        {
            get
            {
                return this.partnamedisplayField;
            }
            set
            {
                this.partnamedisplayField = value;
                this.RaisePropertyChanged("partnamedisplay");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation-display")]
        public namedisplay partabbreviationdisplay
        {
            get
            {
                return this.partabbreviationdisplayField;
            }
            set
            {
                this.partabbreviationdisplayField = value;
                this.RaisePropertyChanged("partabbreviationdisplay");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("staff-spacing")]
        public decimal staffspacing
        {
            get
            {
                return this.staffspacingField;
            }
            set
            {
                this.staffspacingField = value;
                this.RaisePropertyChanged("staffspacing");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool staffspacingSpecified
        {
            get
            {
                return this.staffspacingFieldSpecified;
            }
            set
            {
                this.staffspacingFieldSpecified = value;
                this.RaisePropertyChanged("staffspacingSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("new-system")]
        public yesno newsystem
        {
            get
            {
                return this.newsystemField;
            }
            set
            {
                this.newsystemField = value;
                this.RaisePropertyChanged("newsystem");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newsystemSpecified
        {
            get
            {
                return this.newsystemFieldSpecified;
            }
            set
            {
                this.newsystemFieldSpecified = value;
                this.RaisePropertyChanged("newsystemSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("new-page")]
        public yesno newpage
        {
            get
            {
                return this.newpageField;
            }
            set
            {
                this.newpageField = value;
                this.RaisePropertyChanged("newpage");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newpageSpecified
        {
            get
            {
                return this.newpageFieldSpecified;
            }
            set
            {
                this.newpageFieldSpecified = value;
                this.RaisePropertyChanged("newpageSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("blank-page", DataType = "positiveInteger")]
        public string blankpage
        {
            get
            {
                return this.blankpageField;
            }
            set
            {
                this.blankpageField = value;
                this.RaisePropertyChanged("blankpage");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("page-number", DataType = "token")]
        public string pagenumber
        {
            get
            {
                return this.pagenumberField;
            }
            set
            {
                this.pagenumberField = value;
                this.RaisePropertyChanged("pagenumber");
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