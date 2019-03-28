using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Core.Graphics.SVG
{
    public class SVG
    {
        public SVG()
        {
            return;
        }

        public Type[] Types
        {
            get;
            set;
        }

        public string ToXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(svgType), Types);

            string svg = null;
            using(StringWriter tw = new StringWriter())
            {
                serializer.Serialize(tw, this.Content);
                svg = tw.ToString();
            }

            return svg;
        }

        public svgType Content = null;

    }

}

