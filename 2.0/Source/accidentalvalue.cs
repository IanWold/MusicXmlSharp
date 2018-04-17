using System;
using System.Linq;
using System.Collections.Generic;

namespace MusicXml
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "accidental-value")]
    public enum accidentalvalue
    {

        /// <remarks/>
        sharp,

        /// <remarks/>
        natural,

        /// <remarks/>
        flat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("double-sharp")]
        doublesharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("sharp-sharp")]
        sharpsharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("flat-flat")]
        flatflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("natural-sharp")]
        naturalsharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("natural-flat")]
        naturalflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("quarter-flat")]
        quarterflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("quarter-sharp")]
        quartersharp,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("three-quarters-flat")]
        threequartersflat,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("three-quarters-sharp")]
        threequarterssharp,
    }

}