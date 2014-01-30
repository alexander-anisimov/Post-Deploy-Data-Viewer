using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Post_DeployDataViewer
{
	public class Serialization
	{
		public class Table
		{
			[XmlElement("Value")]
			public string Value
			{ get; set; }
		}

		static public void SerializeToXML(Table movie)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Table));
			TextWriter textWriter = new StreamWriter(@"C:\fileformat.xml");
			serializer.Serialize(textWriter, movie);
			textWriter.Close();
		}

		static public void SerializeToXML(List<Table> movies)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));
			TextWriter textWriter = new StreamWriter(@"C:\fileformat.xml");
			serializer.Serialize(textWriter, movies);
			textWriter.Close();
		}

		static public List<Table> DeserializeFromXML(string url)
		{
			XmlSerializer deserializer = new XmlSerializer(typeof(List<Table>));
			TextReader textReader = new StreamReader(@"C:\temp\" + Path.GetFileName(url).ToString());
			List<Table> movies;
			movies = (List<Table>)deserializer.Deserialize(textReader);
			textReader.Close();

			return movies;
		}

		static public string[] DeserializeFromXMLArray(string url)
		{
			XmlSerializer deserializer = new XmlSerializer(typeof(List<Table>));
			TextReader textReader = new StreamReader(@"C:\temp\" + Path.GetFileName(url).ToString());
			
			List<Table> movies;
			movies = (List<Table>)deserializer.Deserialize(textReader);

			string[] tags = movies.Select(x => x.Value).ToArray();
			textReader.Close();

            //string[] tags2 = new string[3]; // TODO: add dynamic string[]
            //for (int i = 0; i < tags2.Length; i++) 
            //    tags2[i]= movies[i].ToString();

			return tags;
		}

	}
}
