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
	public partial class frmMain : Form
	{
		// param Flag for xml file
		bool IsXMLFile = true;

		public frmMain()
		{
			InitializeComponent();
			txtBoxDataFilePath.Hide();
		}

		private void btnOpenFile(object sender, EventArgs e)
		{
			// Get Path to File
			DialogResult result = PathToLocalFile.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtBoxXMLPath.Text = PathToLocalFile.FileName;
				txtBoxDataFilePath.Text = PathToLocalFile.FileName;
			}
		}

		private void btnUploadFile_Click(object sender, EventArgs e)
		{
			// Dowload File to Temp directory
			string urlXML = txtBoxXMLPath.Text;
			string urlDataFile = txtBoxDataFilePath.Text;

			WebClient webClient = new WebClient();
			string path;
			path = "c:\\temp\\";
			webClient.DownloadFile(urlXML ?? urlDataFile, path + "\\" + Path.GetFileName(urlXML ?? urlDataFile));

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

			if (IsXMLFile)
			{
				List<Serialization.Table> tt2 = Serialization.DeserializeFromXML(Path.GetFileName(urlXML));
				MessageBox.Show("XML Mapping file loaded. Now upload data file");
			}

			txtBoxXMLPath.Hide();
			txtBoxDataFilePath.Clear();
			txtBoxDataFilePath.Show();

			IsXMLFile = false;
		}

		private void btnViewData_Click(object sender, EventArgs e)
		{
			frmDataView frmDataView = new frmDataView();
			frmDataView.Show();
		}
	}
}
