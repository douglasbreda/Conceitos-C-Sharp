using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Library;

namespace SerializerXML
{
    class Program
    {
        static void Main( string[] args )
        {
            User oUser = new User() { Name = "Douglas", Email = "bredadouglas@gmail.com", Identification = "000.000.000-92" };

            XmlSerializer oXmlSerializer = new XmlSerializer( typeof( User ) );

            StreamWriter oStreamWriter = new StreamWriter( "serializedXML.xml" );

            oXmlSerializer.Serialize( oStreamWriter, oUser );
        }
    }
}
