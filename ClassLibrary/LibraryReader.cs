using System;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Xml.Serialization;

//  Potwierdzam samodzielność powyższej pracy oraz niekorzystanie przeze mnie z niedozwolonych źródeł
//  Mikołaj Ryll

namespace LibraryProject
{
    static public class LibraryReader
    {
        private static bool isOK = true;

        private static void ValidationHandler(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                Console.WriteLine("Warning: {0}\n", args.Message);
            else
                Console.WriteLine("Error: {0}\n", args.Message);
            isOK = false;
        }

        static public Library.RootElement ReadLibrary(string path, string xsd_path, string lib_url)
        {
            XmlReaderSettings settings = new XmlReaderSettings
            {
                ValidationType = ValidationType.Schema
            };

            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;

            settings.Schemas.Add(lib_url, xsd_path);

            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;

            settings.ValidationEventHandler += ValidationHandler;

            XmlReader reader = XmlReader.Create(path, settings);

            while (reader.Read()) ;

            reader.Close();

            if (isOK)
                return ReadLibrary(path);
            else
                throw new XmlSchemaValidationException("Invalid XML file");
        }
        static public Library.RootElement ReadLibrary(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Library.RootElement));
            Library.RootElement pas = (Library.RootElement)xs.Deserialize(fs);
            fs.Close();
            return pas;
        }
    }
}
