using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prototype_Game
{
    public class DictionaryLoader
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

            //[XmlElement("def")]
            //public List<string> keyDefinition = new List<string>();
        }


        public List<string> xEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_x-entries.xml");
           var result = (entries)deserializer.Deserialize(reader);

           var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
           return dict;
        }

        public List<string> aEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_a-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> bEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_b-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> cEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_c-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> dEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_d-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> eEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_e-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> fEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_f-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> gEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_g-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> hEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_h-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> iEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_i-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> jEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_j-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> kEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_k-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> lEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_l-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> mEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_m-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> nEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_n-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> oEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_o-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> pEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_p-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> qEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_q-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> rEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_r-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> sEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_s-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> tEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_t-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> uEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_u-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> vEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_v-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> wEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_w-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> yEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_y-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

        public List<string> zEntries()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(@"gcide_z-entries.xml");
            var result = (entries)deserializer.Deserialize(reader);

            var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
            return dict;
        }

    }
}
