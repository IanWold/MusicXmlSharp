# MusicXmlSharp

I took the MusicXML XSD files and ran them through xsd.exe. I sorted the library out into separate class files, and they're all annotated with everything you need to do the fancy autoparsing from XML into the library. Some of the classes even seemt to implement `INotifyPropertyChanged`, so you can probably databind right out of the bat.

## Development

I'm going to be using this for a couple different projects in the future, so this repo is going to act as a place to fork from; I'm not doing any real development here. Feel free to fork it yourself!

If you want to help improve it, by all means feel free to tackle the 25,000 generated lines, I'm not going to stop you. I have a couple of tools to automatically traverse the library and add superficial features into the classes - if there's something simple you think should be added, go ahead and open an issue and we'll see if it can be done!

One interesting thing to do would be to try to automatically document the code and generate some docs. Properties are all prefaced by:

```c#
/// <remarks/>
```

# License

Public domain! w00t!
