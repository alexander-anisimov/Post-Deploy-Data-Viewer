namespace Post_DeployDataViewer
{
	partial class frmDataView
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.PathToLocalFile = new System.Windows.Forms.OpenFileDialog();
			this.txtBoxDataFilePath = new System.Windows.Forms.TextBox();
			this.btnUploadFile = new System.Windows.Forms.Button();
			this.OpenFile = new System.Windows.Forms.Button();
			this.lblChooseDataFile = new System.Windows.Forms.Label();
			this.btnSaveChangesToFile = new System.Windows.Forms.Button();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 100);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(340, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// PathToLocalFile
			// 
			this.PathToLocalFile.FileName = "PathToLocalFile";
			// 
			// txtBoxDataFilePath
			// 
			this.txtBoxDataFilePath.Location = new System.Drawing.Point(12, 59);
			this.txtBoxDataFilePath.Name = "txtBoxDataFilePath";
			this.txtBoxDataFilePath.Size = new System.Drawing.Size(167, 20);
			this.txtBoxDataFilePath.TabIndex = 4;
			// 
			// btnUploadFile
			// 
			this.btnUploadFile.Location = new System.Drawing.Point(277, 56);
			this.btnUploadFile.Name = "btnUploadFile";
			this.btnUploadFile.Size = new System.Drawing.Size(75, 23);
			this.btnUploadFile.TabIndex = 6;
			this.btnUploadFile.Text = "Upload";
			this.btnUploadFile.UseVisualStyleBackColor = true;
			this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
			// 
			// OpenFile
			// 
			this.OpenFile.Location = new System.Drawing.Point(196, 56);
			this.OpenFile.Name = "OpenFile";
			this.OpenFile.Size = new System.Drawing.Size(75, 23);
			this.OpenFile.TabIndex = 5;
			this.OpenFile.Text = "Open File..";
			this.OpenFile.UseVisualStyleBackColor = true;
			this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
			// 
			// lblChooseDataFile
			// 
			this.lblChooseDataFile.AutoSize = true;
			this.lblChooseDataFile.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblChooseDataFile.Location = new System.Drawing.Point(12, 18);
			this.lblChooseDataFile.Name = "lblChooseDataFile";
			this.lblChooseDataFile.Size = new System.Drawing.Size(161, 16);
			this.lblChooseDataFile.TabIndex = 7;
			this.lblChooseDataFile.Text = "Choose a data file to upload";
			// 
			// btnSaveChangesToFile
			// 
			this.btnSaveChangesToFile.Location = new System.Drawing.Point(277, 18);
			this.btnSaveChangesToFile.Name = "btnSaveChangesToFile";
			this.btnSaveChangesToFile.Size = new System.Drawing.Size(75, 23);
			this.btnSaveChangesToFile.TabIndex = 8;
			this.btnSaveChangesToFile.Text = "Save";
			this.btnSaveChangesToFile.UseVisualStyleBackColor = true;
			this.btnSaveChangesToFile.Click += new System.EventHandler(this.btnSaveChangesToFile_Click);
			// 
			// frmDataView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 262);
			this.Controls.Add(this.btnSaveChangesToFile);
			this.Controls.Add(this.lblChooseDataFile);
			this.Controls.Add(this.btnUploadFile);
			this.Controls.Add(this.OpenFile);
			this.Controls.Add(this.txtBoxDataFilePath);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmDataView";
			this.Text = "frmDataView";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.OpenFileDialog PathToLocalFile;
		private System.Windows.Forms.TextBox txtBoxDataFilePath;
		private System.Windows.Forms.Button btnUploadFile;
		private System.Windows.Forms.Button OpenFile;
		private System.Windows.Forms.Label lblChooseDataFile;
		private System.Windows.Forms.Button btnSaveChangesToFile;
		private System.Windows.Forms.SaveFileDialog SaveFileDialog;
	}
}