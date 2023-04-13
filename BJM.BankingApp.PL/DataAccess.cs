using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BJM.BankingApp.PL
{
    public class DataAccess
    {
        // properties 
        public static string XMLFilePath { get; set; } = "";

        // methods
        public static void SaveXML(Type type, object obj)
        {
            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                XmlSerializer serializer= new XmlSerializer(type);
                serializer.Serialize(writer, obj);
            }
        }
        public static object? LoadXml(Type type)
        {
            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                return serializer.Deserialize(reader);
            }
        }
    }
}
