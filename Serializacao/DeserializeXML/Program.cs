using System;
using System.IO;
using System.Xml.Serialization;
using Library;

namespace DeserializeXML
{
    class Program
    {
        static void Main( string[] args )
        {
            StreamReader streamReader = new StreamReader( "..\\..\\..\\Files\\serializedXML.xml" );
            XmlSerializer serializer = new XmlSerializer( typeof( User ) );

            User user = ( User ) serializer.Deserialize( streamReader );

            Console.WriteLine( $"Usuário: {user.Name}, CPF: {user.Identification}, Email: {user.Email} " );
            Console.ReadKey();
        }
    }
}
