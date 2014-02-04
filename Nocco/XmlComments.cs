using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Nocco
{
    public class XmlComments
    {
        public XmlComments(string input)
        {
            this.Input = input;
            var clean = "<wrapper>" + this.Input.Replace("///", "") + "</wrapper>";
            this.Xml = XDocument.Parse(clean);
        }

        public string Input
        {
            get;
            private set;
        }

        public XDocument Xml
        {
            get;
            private set;
        }
    }
}
