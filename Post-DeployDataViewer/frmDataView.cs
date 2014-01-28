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

namespace Post_DeployDataViewer
{
	public partial class frmDataView : Form
	{
		public frmDataView()
		{
			InitializeComponent();
		}

		private void btnUploadFile_Click(object sender, EventArgs e)
		{
			// Dowload File to Temp directory
			string urlDataFile = txtBoxDataFilePath.Text;

			WebClient webClient = new WebClient();
			string path;
			path = "c:\\temp\\";
			webClient.DownloadFile(urlDataFile, path + "\\" + Path.GetFileName(urlDataFile));

			Stream dfStream = PathToLocalFile.OpenFile();
			StreamReader dfStreamReader = new StreamReader(dfStream);

			//List<Serialization.Table> tt1 = Serialization.DeserializeFromXML(Path.GetFileName("fileformat.xml"));
			string[] tt2 = Serialization.DeserializeFromXMLArray(Path.GetFileName("fileformat.xml"));
			
			DataSet ds = new DataSet();
			ds.Tables.Add("DataFile");

			foreach (string tag in tt2) // Loop through List with foreach
			{
				ds.Tables[0].Columns.Add(tag);
			}


			//ds.Tables[0].Columns.Add("ID");
			//ds.Tables[0].Columns.Add("Name");
			//ds.Tables[0].Columns.Add("Value");

			string[] dfStringRowArray = dfStreamReader.ReadToEnd().Split('\n');
			int rowCount = dfStringRowArray.Count();

			for (int i = 0; i < rowCount; i++)
			{
				string[] rvalue = System.Text.RegularExpressions.Regex.Split(dfStringRowArray[i], "	");
				ds.Tables[0].Rows.Add(rvalue);
			}

			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.Update();
		}

		private void OpenFile_Click(object sender, EventArgs e)
		{
			// Get Path to File
			DialogResult result = PathToLocalFile.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtBoxDataFilePath.Text = PathToLocalFile.FileName;
			}
		}

	}
}
