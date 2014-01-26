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

		public frmMain()
		{
			InitializeComponent();
		}

		// Open button: choose a file and get file Path
		public void btnOpenFile(object sender, EventArgs e)
		{
			// Get Path to File
			DialogResult result = PathToLocalFile.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtBoxXMLPath.Text = PathToLocalFile.FileName;
			}
		}

		// Upload button: parsing XML file through serialization
		private void btnUploadFile_Click(object sender, EventArgs e)
		{
			// Dowload File to Temp directory
			string urlXML = txtBoxXMLPath.Text;
			//string urlDataFile = txtBoxDataFilePath.Text;

			WebClient webClient = new WebClient();
			string path;
			path = "c:\\temp\\";
			webClient.DownloadFile(urlXML, path + "\\" + Path.GetFileName(urlXML));

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

			List<Serialization.Table> tt2 = Serialization.DeserializeFromXML(Path.GetFileName(urlXML));
			MessageBox.Show("XML Mapping file loaded. Now upload data file");
		}

		// Next button
		private void btnViewData_Click(object sender, EventArgs e)
		{
			frmDataView frmDataView = new frmDataView();
			frmDataView.Show();
		}
	}
}
