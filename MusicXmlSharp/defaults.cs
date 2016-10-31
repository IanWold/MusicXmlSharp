using System.ComponentModel;

namespace MusicXmlSharp
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class defaults : INotifyPropertyChanged
	{

		private scaling scalingField;

		private pagelayout pagelayoutField;

		private systemlayout systemlayoutField;

		private stafflayout[] stafflayoutField;

		private appearance appearanceField;

		private emptyfont musicfontField;

		private emptyfont wordfontField;

		private lyricfont[] lyricfontField;

		private lyriclanguage[] lyriclanguageField;

		/// <remarks />
		public scaling scaling
		{
			get
			{
				return this.scalingField;
			}
			set
			{
				this.scalingField = value;
				this.RaisePropertyChanged("scaling");
			}
		}

		/// <remarks />
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

		/// <remarks />
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

		/// <remarks />
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

		/// <remarks />
		public appearance appearance
		{
			get
			{
				return this.appearanceField;
			}
			set
			{
				this.appearanceField = value;
				this.RaisePropertyChanged("appearance");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("music-font")]
		public emptyfont musicfont
		{
			get
			{
				return this.musicfontField;
			}
			set
			{
				this.musicfontField = value;
				this.RaisePropertyChanged("musicfont");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("word-font")]
		public emptyfont wordfont
		{
			get
			{
				return this.wordfontField;
			}
			set
			{
				this.wordfontField = value;
				this.RaisePropertyChanged("wordfont");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("lyric-font")]
		public lyricfont[] lyricfont
		{
			get
			{
				return this.lyricfontField;
			}
			set
			{
				this.lyricfontField = value;
				this.RaisePropertyChanged("lyricfont");
			}
		}

		/// <remarks />
		[System.Xml.Serialization.XmlElementAttribute("lyric-language")]
		public lyriclanguage[] lyriclanguage
		{
			get
			{
				return this.lyriclanguageField;
			}
			set
			{
				this.lyriclanguageField = value;
				this.RaisePropertyChanged("lyriclanguage");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}

}
