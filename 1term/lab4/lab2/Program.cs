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
    class Program
    {
        public static void JsonSerial(Feeder feeder, string path)
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



        public static void XmlSerial(Cat[] cats)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Cat[]));
            using (Stream fs = new FileStream("xmlserializer.xml", FileMode.Create))
            {
              
                ser.Serialize(fs, cats);
            }

            using (FileStream fs = new FileStream("xmlserializer.xml", FileMode.OpenOrCreate))
            {
                Cat[] new_animals = (Cat[])ser.Deserialize(fs);
            }
        }

            static void Main(string[] args)
        {
            
            Cat c1 = new Cat(true);
            Cat c2 = new Cat(true);
            Cat c3 = new Cat(true);
            Cat c4 = new Cat(true);

            Hamster h1 = new Hamster(true);
            Hamster h2 = new Hamster(true);

            Feeder feeder1 = new Feeder("Katya", 18, "Female");
            Feeder feeder2 = new Feeder("Stas", 19, "Male");

            Feeder[] feeders = new Feeder[5];

            feeders[0] = feeder1;
            feeders[1] = feeder2;

            //Animal[] animals = new lab1.Animal[] { c1, c2, h1, h2 };
            Cat[] cats = new Cat[] { c1, c2, c3, c4 };

            /*
            Feeder feeder1 = new Feeder("Katya");
            Feeder feeder2 = new Feeder("Stas");
            BigZoo zoo1 = new BigZoo(feeder1);
            SmallZoo zoo2 = new SmallZoo(feeder2);
            feeder1.Feeding();
            feeder2.Feeding();

            Cat c = new lab1.Cat(false);
            Console.WriteLine("\nRacion of cat: \n");
            c.Racion();
            c.SpecialRacion("milk");

            */

            //JsonSerial(feeder1, "obj.json");
            XmlSerial(cats);
            Console.ReadKey();
        }
    }

}

