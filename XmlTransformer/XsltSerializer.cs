using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Xml.Xsl;
using System.Runtime.Serialization.Formatters.Binary;

namespace XmlTransformer
{
    public static class XmlTransformer
    {
        public static void SerializeWithXslt(string xmlPath, string xsltPath, string outputPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);

            XslCompiledTransform transform = new XslCompiledTransform();

            transform.Load(xsltPath);
            using (TextWriter writer = new StreamWriter(outputPath))
            {
                transform.Transform(doc, null, writer);
            }
        }
    }
}
