using MusicXml;
using System;
using System.IO.Compression;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using static System.Console;
using static System.IO.File;

namespace Example
{
    class Program
    {
        /// <summary>
        /// This example expects an MXL file with a score-partwise root element.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string fileName;
            scorepartwise score = new scorepartwise();

            // Get the file name from the user;
            // Check to ensure it exists
            do
            {
                Write(">: ");
                fileName = ReadLine();
            }
            while (!Exists(fileName));

            // Generate GUID for temporary XML file
            var guidFile = Guid.NewGuid().ToString() + ".xml";

            // Unzip the MXL file
            // Get the XML file within; sxculding meta files
            using (var zip = ZipFile.OpenRead(fileName))
            {
                if (zip.Entries.FirstOrDefault(e => e.Name.ToLower().Contains("xml") && !e.FullName.ToLower().Contains("meta")) is ZipArchiveEntry entry)
                {
                    entry.ExtractToFile(guidFile);
                }
                else
                {
                    WriteLine("Could not find entry.");
                }
            }

            // Read temporary XMl file
            // Deserialize to scorepartwise
            // Set DtdProcessing to Parse because that does something
            using (var reader = XmlReader.Create(guidFile, new XmlReaderSettings() { DtdProcessing = DtdProcessing.Parse }))
            {
                var serializer = new XmlSerializer(typeof(scorepartwise));
                if (serializer.CanDeserialize(reader) && serializer.Deserialize(reader) is scorepartwise result)
                {
                    score = result;
                }
                else
                {
                    WriteLine("Could not deserialize XML file.");
                }
            }

            // Delete temporary XML file
            Delete(guidFile);

            // See that we have read the MXL file
            WriteLine(score.version);
            ReadLine();
        }
    }
}
