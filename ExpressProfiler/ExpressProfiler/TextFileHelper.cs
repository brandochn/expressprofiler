using System;
using System.IO;

namespace ExpressProfiler
{
    public class TextFileHelper
    {
        public static string ReadAllText(string fileName)
        {
            if (fileName == null)
                throw new ArgumentNullException("fileName");

            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
    }
}