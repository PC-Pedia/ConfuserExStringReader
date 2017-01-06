namespace ConfuserExStringReader
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
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.txtAssembly = new System.Windows.Forms.TextBox();
			this.btnRead = new System.Windows.Forms.Button();
			this.txtClassName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMethodName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkIgnoreEmpty = new System.Windows.Forms.CheckBox();
			this.numPacks = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPacks)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(592, 37);
			this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(124, 28);
			this.btnSelectFile.TabIndex = 0;
			this.btnSelectFile.Text = "Select Assembly";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// txtAssembly
			// 
			this.txtAssembly.Location = new System.Drawing.Point(8, 39);
			this.txtAssembly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAssembly.Name = "txtAssembly";
			this.txtAssembly.Size = new System.Drawing.Size(575, 22);
			this.txtAssembly.TabIndex = 1;
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(608, 192);
			this.btnRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(120, 37);
			this.btnRead.TabIndex = 2;
			this.btnRead.Text = "Read Strings";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// txtClassName
			// 
			this.txtClassName.Location = new System.Drawing.Point(8, 130);
			this.txtClassName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtClassName.Name = "txtClassName";
			this.txtClassName.Size = new System.Drawing.Size(275, 22);
			this.txtClassName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Assembly File:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(244, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Main string decryption class full name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 111);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(246, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "(e.g: namespaceXYZ.classNameXYZ)";
			// 
			// txtMethodName
			// 
			this.txtMethodName.Location = new System.Drawing.Point(308, 130);
			this.txtMethodName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMethodName.Name = "txtMethodName";
			this.txtMethodName.Size = new System.Drawing.Size(275, 22);
			this.txtMethodName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(304, 111);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "(e.g: methodNameXYZ)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(304, 95);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(199, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "String decryptor method name";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnSelectFile);
			this.groupBox1.Controls.Add(this.txtAssembly);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtClassName);
			this.groupBox1.Controls.Add(this.txtMethodName);
			this.groupBox1.Location = new System.Drawing.Point(16, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(727, 170);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// chkIgnoreEmpty
			// 
			this.chkIgnoreEmpty.AutoSize = true;
			this.chkIgnoreEmpty.Location = new System.Drawing.Point(24, 192);
			this.chkIgnoreEmpty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkIgnoreEmpty.Name = "chkIgnoreEmpty";
			this.chkIgnoreEmpty.Size = new System.Drawing.Size(158, 21);
			this.chkIgnoreEmpty.TabIndex = 10;
			this.chkIgnoreEmpty.Text = "Ignore empty strings";
			this.chkIgnoreEmpty.UseVisualStyleBackColor = true;
			// 
			// numPacks
			// 
			this.numPacks.Location = new System.Drawing.Point(323, 192);
			this.numPacks.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numPacks.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numPacks.Name = "numPacks";
			this.numPacks.Size = new System.Drawing.Size(120, 22);
			this.numPacks.TabIndex = 11;
			this.numPacks.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(207, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Records in pack";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 239);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numPacks);
			this.Controls.Add(this.chkIgnoreEmpty);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "ConfuserEx Strings Reader (by SalaR)";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPacks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox txtAssembly;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.TextBox txtClassName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMethodName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkIgnoreEmpty;
		private System.Windows.Forms.NumericUpDown numPacks;
		private System.Windows.Forms.Label label6;
	}
}

