using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ExpressProfiler
{
    public static class XmlHelper
    {
        public static T DeserializeXml<T>(string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (TextReader reader = new StringReader(xmlString))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public static string SerializeXml<T>(T objectToSerialize)
        {
            var utf8NoBom = new UTF8Encoding(false);
            Type serializationType = typeof(T);

            if (serializationType == typeof(object) && objectToSerialize != null)
            {
                serializationType = objectToSerialize.GetType();
            }

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            using (var memoryStream = new MemoryStream())
            {
                var xs = new XmlSerializer(serializationType);
                using (var xmlTextWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings() { Encoding = utf8NoBom }))
                {
                    xs.Serialize(xmlTextWriter, objectToSerialize, ns);

                    return Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
        }

        public static void WriteXml(string folderPath, string fileName, string content)
        {
            if (fileName == null)
                throw new ArgumentNullException("fileName");

            if (!Directory.Exists(folderPath))
                throw new DirectoryNotFoundException(string.Format("the directory '{0}' does not exists", folderPath));

            var fullPath = System.IO.Path.Combine(folderPath, fileName);

            if (File.Exists(fullPath))
                File.Delete(fullPath);

            System.IO.File.WriteAllText(fullPath, content);
        }
    }
}