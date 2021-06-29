using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlSample = @"
            <xml version='1.0'>
                <email>
                    <from>Anas</from>
                    <to>Saud</to>
                    <content>
                        <introduction>Mr.Saud, I hope this email finds you well.</introduction>
                        <body>Welcome to C# course.</body>
                        <conclusion> Best regards,</conclusion>
                    </content>
                </email>
            </xml>
        ";

            // without Facade
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlSample);
            List<XmlNode> parsedXml = ParseXml(xmlDoc.DocumentElement, new List<XmlNode>());
            var selectedElement = getElementByTagNameFromList(parsedXml, "email");
            Console.WriteLine(selectedElement.Name);

            // with Facade
            var selectedElement2 = getElementByTagName(xmlSample, "conclusion");
            Console.WriteLine(selectedElement2.Name);
        }
        private static XmlNode getElementByTagName(string xmlSample, string tag)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlSample);
            List<XmlNode> parsedXml = ParseXml(xmlDoc.DocumentElement, new List<XmlNode>());
            return getElementByTagNameFromList(parsedXml, tag);
        }

        private static List<XmlNode> ParseXml(XmlNode LoadedXmlNode, List<XmlNode> NodeList)
        {
            if(LoadedXmlNode.NodeType == XmlNodeType.Element)
            {
                NodeList.Add(LoadedXmlNode);
            }

            foreach (XmlNode node in LoadedXmlNode.ChildNodes)
            {
                ParseXml(node, NodeList);
            }

            return NodeList;
        }

        private static XmlNode getElementByTagNameFromList(List<XmlNode> NodeList, string tag)
        {
            foreach(var node in NodeList)
            {
                if(node.Name == tag)
                {
                    return node;
                }
            }

            return null;
        }
    }
}
