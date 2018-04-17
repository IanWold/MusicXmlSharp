# MusicXmlSharp

I took the MusicXML XSD files and ran them through xsd.exe. I sorted the library out into separate class files, and they're all annotated with everything you need to do the fancy autoparsing from XML into the library. The classes implement `INotifyPropertyChanged`, so you can databind right out of the bat.

MusicXML versions 2.0, 3.0, and 3.1 are all included.

Deserialize XML files with [XmlSerializer.Deserialize](https://msdn.microsoft.com/en-us/library/tz8csy73(v=vs.110).aspx)

MXL files are MusicXML files compressed as ZIP files ([see here](https://www.musicxml.com/tutorial/compressed-mxl-files/compressed-file-format/)). To read these, use [ZipFile.OpenRead](https://msdn.microsoft.com/en-us/library/system.io.compression.zipfile.openread(v=vs.110).aspx) before deserializing.

## Development

I'm going to be using this for a couple different projects in the future, so this repo is going to act as a place to fork from; I'm not doing any real development here. Feel free to fork it yourself!

If you want to help improve it, by all means feel free to tackle the 25,000 generated lines, I'm not going to stop you. I have a couple of tools to automatically traverse the library and add superficial features into the classes - if there's something simple you think should be added, go ahead and open an issue and we'll see if it can be done!

One interesting thing to do would be to try to automatically document the code and generate some docs. Properties are all prefaced by:

```c#
/// <remarks/>
```

# License

Public domain! w00t!
