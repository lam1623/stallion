using System;
using System.Xml;

namespace stallion
{
	public class xmlfile
	{
		private static string xmldir = Environment.GetEnvironmentVariable("HOME")+"/.config/stallion/";
		private string xml = xmldir+"cfg.xml";
		
		public xmlfile ()
		{
		}		
		
		public bool XmlExits()
		{
			if (System.IO.File.Exists(xml))
				return true;
			else
				return false;						
		}		
			
		public void CreateXmlFile()
		{
			XmlDocument xmldoc = new XmlDocument();
			XmlNode xmlRoot, xmlNode;
			xmlRoot = xmldoc.CreateElement("CONFIG");
			
			xmldoc.AppendChild(xmlRoot);	
				
			xmlNode = xmldoc.CreateElement("unix");
			xmlRoot.AppendChild(xmlNode);
				
			xmlNode = xmldoc.CreateElement("aplicacion");
			xmlRoot.AppendChild(xmlNode);
				
			xmlNode = xmldoc.CreateElement("window");
			xmlRoot.AppendChild(xmlNode);
			
			xmlNode = xmldoc.CreateElement("option");
			xmlRoot.AppendChild(xmlNode);
			
			if (!System.IO.Directory.Exists(xmldir))
				System.IO.Directory.CreateDirectory(xmldir);
			
			xmldoc.Save(xml);			
		}		
		
		public void SetXmlFile(string nodo, string attr,string values) 
		{
			XmlDocument xmldoc = new XmlDocument();
		   	xmldoc.Load(xml);	   	
			XmlNodeList xmlnode = xmldoc.GetElementsByTagName(nodo);
			
			for(int i=0;i<xmlnode.Count;i++) 
				if ( xmlnode[i].Name == nodo)
				{
				   XmlAttribute xmlat1 = xmldoc.CreateAttribute(attr);
	               xmlat1.InnerText = values;               
	               xmlnode[i].Attributes.Append(xmlat1);
				}            
			
			xmldoc.Save(xml);
		}
		
		public String GetXmlFile(string nodo, string attr) 
		{
			string result = "";
			string file = xml;
			XmlDocument xmldoc = new XmlDocument();
			if (System.IO.File.Exists(file))
			{
		   		xmldoc.Load(file);	   	
				XmlNodeList xmlnode = xmldoc.GetElementsByTagName(nodo);		
		   		for(int i=0;i<xmlnode.Count;i++)
		   		{
		  			XmlAttributeCollection xmlattrc = xmlnode[i].Attributes;			 		
					for(int j=0;j<xmlattrc.Count;j++) 			  
					if (attr == xmlattrc[j].Name)				
						result = xmlattrc[j].Value;
				}	
			}
		 	return result;					
		}		
	}
}

