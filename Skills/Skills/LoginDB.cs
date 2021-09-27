using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace Skills
{
    class LoginDB
    {
        private const string Path = @"..\..\login.xml";

        /// <summary>
        /// retrieves all the logins 
        /// </summary>
        /// <returns>List with type login</returns>
        public static List<Login> GetLogin()
        {
            List<Login> logins = new List<Login>();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            XmlReader xmlIn = XmlReader.Create(Path, settings);

            if (xmlIn.ReadToDescendant("login"))
            {
                // Makes a new instance of the class Login and add them to the list
                do
                {
                    Login login = new Login();
                    xmlIn.ReadStartElement("login");
                    login.Username =
                        xmlIn.ReadElementContentAsString();
                    login.Password =
                        xmlIn.ReadElementContentAsString();
                    logins.Add(login);
                }
                while (xmlIn.ReadToNextSibling("login"));
            }

            //Closes the .xml file and returns the list full of logins
            xmlIn.Close();

            return logins;
        }
        /// <summary>
        /// adds new login to the .xml file
        /// </summary>
        /// <param name="logins">list of type Login</param>
        public static void SaveLogin(List<Login> logins)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Logins");

            // write each product object to the xml file
            foreach (Login login in logins)
            {
                xmlOut.WriteStartElement("login");
                xmlOut.WriteElementString("username",
                    login.Username);
                xmlOut.WriteElementString("password",
                    login.Password);
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}