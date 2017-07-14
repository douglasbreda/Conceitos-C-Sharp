using System.IO;
using System.Web.Script.Serialization;
using Library;

namespace SerializerJSON
{
    class Program
    {
        static void Main( string[] args )
        {
            User oUser = new User() { Name = "Douglas", Email = "bredadouglas@gmail.com", Identification = "000.000.000-92" };

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string sJson = serializer.Serialize( oUser );

            StreamWriter oStreamWriter = new StreamWriter( "..\\..\\..\\Files\\serializedXML.json" );
            oStreamWriter.Write( sJson );
            oStreamWriter.Close();
        }
    }
}
