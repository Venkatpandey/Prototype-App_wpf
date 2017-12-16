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

        /// <summary>
        /// Mini function to prepare dictionary path for the last alphabet
        /// </summary>
        /// <param name="lastAlpha"></param>
        /// <returns></returns>
        private string streamPath(char lastAlpha)
        {
            string preparePath = String.Format(@"C:\sandbox\GitHub\DictResource\gcide_{0}-entries.xml", lastAlpha);
            
            return preparePath;
        }
        
        /// <summary>
        /// returns loaded dictionary for last alphabet
        /// </summary>
        /// <param name="lastAlpha"></param>
        /// <returns></returns>
        public List<string> Entries(char lastAlpha)
        {
            var streamPath = this.streamPath(lastAlpha);
            XmlSerializer deserializer = new XmlSerializer(typeof(entries));
            TextReader reader = new StreamReader(streamPath);
            var result = (entries)deserializer.Deserialize(reader);
            reader.Close();

           var dict = result.keyEntry.Select(xx => xx.keyWords).ToList();
           return dict;
        }
    }
}
