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

		// Upload button: serialization file and get Grid on page
		private void btnUploadFile_Click(object sender, EventArgs e)
		{
			string urlDataFile = txtBoxDataFilePath.Text; // Dowload File to Temp directory

			WebClient webClient = new WebClient();
			string path;
			path = "c:\\temp\\";
			webClient.DownloadFile(urlDataFile, path + "\\" + Path.GetFileName(urlDataFile));

			Stream dfStream = PathToLocalFile.OpenFile();
			StreamReader dfStreamReader = new StreamReader(dfStream);

			string[] tt2 = Serialization.DeserializeFromXMLArray(Path.GetFileName("fileformat.xml"));
			
			DataSet ds = new DataSet();
			ds.Tables.Add("DataFile");

			foreach (string tag in tt2) // Loop through List with foreach
			{
				ds.Tables[0].Columns.Add(tag);
			}

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

		// Open button: choose a file and get file Path
		private void OpenFile_Click(object sender, EventArgs e)
		{
			DialogResult result = PathToLocalFile.ShowDialog(); // Get Path to File
			if (result == DialogResult.OK)
			{
				txtBoxDataFilePath.Text = PathToLocalFile.FileName;
			}
		}

	}
}
