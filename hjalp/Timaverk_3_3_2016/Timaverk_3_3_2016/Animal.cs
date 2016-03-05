using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Timaverk_3_3_2016
{
    [Serializable]
    public class Animal
    {
        [XmlAttribute]
        public string name { get; set; }
        [XmlAttribute]
        public string age { get; set; }
        [XmlAttribute]
        public string skrnNr { get; set; }
        

        
        }

    public class Dyr
    {
        public Dyr()
        {
            dyralisti = new List<Animal>();
        }
        public List<Animal> dyralisti { get; set; }


    }
}