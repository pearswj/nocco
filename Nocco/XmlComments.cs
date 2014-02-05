using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Nocco
{
    public class XmlComments
    {
        public XmlComments(string input)
        {
            this.Input = input;
            var clean = "<wrapper>\n" + Regex.Replace(this.Input, "[\\t ]*///\\s*", "") + "\n</wrapper>";
            System.Console.WriteLine(clean);
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

        public string Markdown
        {
            get;
            private set;
        }
    }
}
