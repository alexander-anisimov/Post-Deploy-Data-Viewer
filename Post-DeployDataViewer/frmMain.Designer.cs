namespace Post_DeployDataViewer
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OpenFile = new System.Windows.Forms.Button();
			this.txtBoxXMLPath = new System.Windows.Forms.TextBox();
			this.btnUploadFile = new System.Windows.Forms.Button();
			this.PathToLocalFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.PathToLocalFile = new System.Windows.Forms.OpenFileDialog();
			this.txtBoxDataFilePath = new System.Windows.Forms.TextBox();
			this.btnViewData = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// OpenFile
			// 
			this.OpenFile.Location = new System.Drawing.Point(196, 162);
			this.OpenFile.Name = "OpenFile";
			this.OpenFile.Size = new System.Drawing.Size(75, 23);
			this.OpenFile.TabIndex = 0;
			this.OpenFile.Text = "Open File..";
			this.OpenFile.UseVisualStyleBackColor = true;
			this.OpenFile.Click += new System.EventHandler(this.btnOpenFile);
			// 
			// txtBoxXMLPath
			// 
			this.txtBoxXMLPath.Location = new System.Drawing.Point(25, 165);
			this.txtBoxXMLPath.Name = "txtBoxXMLPath";
			this.txtBoxXMLPath.Size = new System.Drawing.Size(154, 20);
			this.txtBoxXMLPath.TabIndex = 1;
			// 
			// btnUploadFile
			// 
			this.btnUploadFile.Location = new System.Drawing.Point(277, 162);
			this.btnUploadFile.Name = "btnUploadFile";
			this.btnUploadFile.Size = new System.Drawing.Size(75, 23);
			this.btnUploadFile.TabIndex = 2;
			this.btnUploadFile.Text = "Upload";
			this.btnUploadFile.UseVisualStyleBackColor = true;
			this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
			// 
			// PathToLocalFolder
			// 
			this.PathToLocalFolder.SelectedPath = "C:\\";
			this.PathToLocalFolder.ShowNewFolderButton = false;
			// 
			// PathToLocalFile
			// 
			this.PathToLocalFile.FileName = "PathToLocalFile";
			// 
			// txtBoxDataFilePath
			// 
			this.txtBoxDataFilePath.Location = new System.Drawing.Point(12, 165);
			this.txtBoxDataFilePath.Name = "txtBoxDataFilePath";
			this.txtBoxDataFilePath.Size = new System.Drawing.Size(167, 20);
			this.txtBoxDataFilePath.TabIndex = 3;
			// 
			// btnViewData
			// 
			this.btnViewData.Location = new System.Drawing.Point(196, 204);
			this.btnViewData.Name = "btnViewData";
			this.btnViewData.Size = new System.Drawing.Size(156, 23);
			this.btnViewData.TabIndex = 4;
			this.btnViewData.Text = "View Data";
			this.btnViewData.UseVisualStyleBackColor = true;
			this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 262);
			this.Controls.Add(this.btnViewData);
			this.Controls.Add(this.txtBoxDataFilePath);
			this.Controls.Add(this.btnUploadFile);
			this.Controls.Add(this.txtBoxXMLPath);
			this.Controls.Add(this.OpenFile);
			this.Name = "frmMain";
			this.Text = "Post-Deploy Data Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OpenFile;
		private System.Windows.Forms.TextBox txtBoxXMLPath;
		private System.Windows.Forms.Button btnUploadFile;
		private System.Windows.Forms.FolderBrowserDialog PathToLocalFolder;
		private System.Windows.Forms.OpenFileDialog PathToLocalFile;
		private System.Windows.Forms.TextBox txtBoxDataFilePath;
		private System.Windows.Forms.Button btnViewData;
	}
}

