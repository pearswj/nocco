using System;
using NUnit.Framework;
using Nocco;
using System.Xml;
using System.Xml.Linq;

namespace NoccoTests
{
    [TestFixture]
    public class XmlCommentsTest
    {
        [Test]
        public void CanParseXML()
        {
            var xml = @"/// <summary>
/// <para>Split a face into two faces by inserting a new edge</para>
/// <seealso cref=""MergeFaces""/>
/// </summary>
/// <param name=""to"">The index of a second halfedge adjacent to the face to split.
/// The new edge will end at the start of this halfedge.</param>
/// <param name=""from"">The index of a halfedge adjacent to the face to split.
/// The new edge will begin at the start of this halfedge.</param>
/// <returns>The index of one of the newly created halfedges, or -1 on failure.
/// The returned halfedge will be adjacent to the pre-existing face.</returns>";

            var SUT = new XmlComments(xml);

            Assert.AreEqual(xml, SUT.Input);

            var ret = "The index of one of the newly created halfedges, or -1 on failure. The returned halfedge will be adjacent to the pre-existing face.";

            foreach (var item in SUT.Xml.Descendants("returns"))
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
