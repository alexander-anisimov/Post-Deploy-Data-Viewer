namespace Post_DeployDataViewer
{
	partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnUploadFile = new System.Windows.Forms.Button();
			this.PathToLocalFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.PathToLocalFile = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// OpenFile
			// 
			this.OpenFile.Location = new System.Drawing.Point(185, 188);
			this.OpenFile.Name = "OpenFile";
			this.OpenFile.Size = new System.Drawing.Size(75, 23);
			this.OpenFile.TabIndex = 0;
			this.OpenFile.Text = "Open File..";
			this.OpenFile.UseVisualStyleBackColor = true;
			this.OpenFile.Click += new System.EventHandler(this.btnOpenFile);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(25, 188);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(154, 20);
			this.textBox1.TabIndex = 1;
			// 
			// btnUploadFile
			// 
			this.btnUploadFile.Location = new System.Drawing.Point(25, 214);
			this.btnUploadFile.Name = "btnUploadFile";
			this.btnUploadFile.Size = new System.Drawing.Size(235, 23);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnUploadFile);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.OpenFile);
			this.Name = "Form1";
			this.Text = "Post-Deploy Data Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OpenFile;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnUploadFile;
		private System.Windows.Forms.FolderBrowserDialog PathToLocalFolder;
		private System.Windows.Forms.OpenFileDialog PathToLocalFile;
	}
}

