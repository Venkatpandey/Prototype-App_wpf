using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prototype_Game
{
    public class LoadDictionary
    {
        public class entries
        {
            [XmlAttribute("letter")]
            public string letter { get; set; }

            [XmlElement("entry")]
            public List<entry> keyEntry = new List<entry>();
        }

        public class entry
        {
            [XmlAttribute("key")]
            public string keyWords { get; set; }

        }

      
        public List<string> xEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_x-entries.xml");
           var result = (entries)deserializer.Deserialize(reader);
           reader.Close();

           var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
           return dict;
        }

        public List<string> aEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_a-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> bEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_b-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> cEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_c-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> dEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_d-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> eEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_e-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> fEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_f-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> gEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_g-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> hEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_h-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> iEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_i-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> jEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_j-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> kEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_k-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> lEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_l-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> mEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_m-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> nEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_n-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> oEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_o-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> pEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_p-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> qEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_q-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> rEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_r-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> sEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_s-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> tEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_t-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> uEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_u-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> vEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_v-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> wEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_w-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> yEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_y-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> zEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"C:\Users\pande\Documents\GitHub\DictResource\gcide_z-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

    }
}
