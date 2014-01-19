using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
// using System.Xml;
using System.Xml.Serialization;

namespace Post_DeployDataViewer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOpenFile(object sender, EventArgs e)
		{
			// Get Path to File
			DialogResult result = PathToLocalFile.ShowDialog();
			if (result == DialogResult.OK)
			{
				textBox1.Text = PathToLocalFile.FileName;
			}
		}

		private void btnUploadFile_Click(object sender, EventArgs e)
		{
			// Dowload File to Temp directory
			string url = textBox1.Text;

			WebClient webClient = new WebClient();
			string path;
			path = "c:\\temp\\";
			webClient.DownloadFile(url, path + "\\" + Path.GetFileName(url));

			//Table t1 = new Table();
			//t1.ID = 20;
			//t1.Name = "First Name";
			//t1.Value = 135;

			//Table t2 = new Table();
			//t2.ID = 18;
			//t2.Name = "Second Name";
			//t2.Value = 456;

			//List<Table> tt1 = new List<Table>() { t1, t2 };
			//SerializeToXML(tt1);

			List<Table> tt2 = DeserializeFromXML(Path.GetFileName(url));
			Console.ReadLine();
		}

		public class Table
		{
			[XmlAttribute("ID")]
			public int ID
			{ get; set; }

			[XmlElement("Name")]
			public string Name
			{ get; set; }

			[XmlElement("Value")]
			public float Value
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

		static List<Table> DeserializeFromXML(string url)
		{
			XmlSerializer deserializer = new XmlSerializer(typeof(List<Table>));
			TextReader textReader = new StreamReader(@"C:\temp\" + Path.GetFileName(url).ToString());
			List<Table> movies;
			movies = (List<Table>)deserializer.Deserialize(textReader);
			textReader.Close();

			return movies;
		}
	}
}
