using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace lab1
{
    // Using "Clean code" rule 
    // Изменение названия метода, чтобы было понятно, что он делает
    // Разбитие метода на два для читабельности и гибкости использования

    class Serialization
    {
        public static void JsonSerialization(Feeder feeder, string path)
        {
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Feeder));
                ser.WriteObject(stream, feeder);
                stream.Position = 0;
                StreamReader streamReader = new StreamReader(stream);
                Console.WriteLine(streamReader.ReadToEnd());
                stream.Position = 0;
                Feeder result = (Feeder)ser.ReadObject(stream);
            }
        }


        public static void XmlSerialization(Cat[] cats)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Cat[]));
            using (Stream fs = new FileStream("xmlserializer.xml", FileMode.Create))
            {

                ser.Serialize(fs, cats);
            }
        }

        public static void XmlDeserialization(Cat[] cats)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Cat[]));
            using (FileStream fs = new FileStream("xmlserializer.xml", FileMode.OpenOrCreate))
            {
                Cat[] new_animals = (Cat[])ser.Deserialize(fs);
            }

        }

    }
}
