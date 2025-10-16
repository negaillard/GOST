namespace GOST
{
	partial class MainForm
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

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblVersion = new Label();
			comboBoxVersion = new ComboBox();
			lblFile = new Label();
			txtFilePath = new TextBox();
			btnSelectFile = new Button();
			btnCalculateHash = new Button();
			lblHash = new Label();
			txtHashResult = new TextBox();
			btnCopyHash = new Button();
			btnClear = new Button();
			lblFileInfo = new Label();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// lblVersion
			// 
			lblVersion.AutoSize = true;
			lblVersion.Location = new Point(26, 89);
			lblVersion.Margin = new Padding(4, 0, 4, 0);
			lblVersion.Name = "lblVersion";
			lblVersion.Size = new Size(140, 20);
			lblVersion.TabIndex = 10;
			lblVersion.Text = "Версия алгоритма:";
			// 
			// comboBoxVersion
			// 
			comboBoxVersion.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxVersion.FormattingEnabled = true;
			comboBoxVersion.Items.AddRange(new object[] { "GOST 256", "GOST 512" });
			comboBoxVersion.Location = new Point(173, 86);
			comboBoxVersion.Margin = new Padding(4, 5, 4, 5);
			comboBoxVersion.Name = "comboBoxVersion";
			comboBoxVersion.Size = new Size(199, 28);
			comboBoxVersion.TabIndex = 9;
			// 
			// lblFile
			// 
			lblFile.AutoSize = true;
			lblFile.Location = new Point(26, 150);
			lblFile.Margin = new Padding(4, 0, 4, 0);
			lblFile.Name = "lblFile";
			lblFile.Size = new Size(48, 20);
			lblFile.TabIndex = 8;
			lblFile.Text = "Файл:";
			// 
			// txtFilePath
			// 
			txtFilePath.Location = new Point(173, 146);
			txtFilePath.Margin = new Padding(4, 5, 4, 5);
			txtFilePath.Name = "txtFilePath";
			txtFilePath.ReadOnly = true;
			txtFilePath.Size = new Size(399, 27);
			txtFilePath.TabIndex = 7;
			// 
			// btnSelectFile
			// 
			btnSelectFile.Location = new Point(586, 143);
			btnSelectFile.Margin = new Padding(4, 5, 4, 5);
			btnSelectFile.Name = "btnSelectFile";
			btnSelectFile.Size = new Size(133, 35);
			btnSelectFile.TabIndex = 6;
			btnSelectFile.Text = "Выбрать файл";
			btnSelectFile.UseVisualStyleBackColor = true;
			btnSelectFile.Click += btnSelectFile_Click;
			// 
			// btnCalculateHash
			// 
			btnCalculateHash.Location = new Point(173, 227);
			btnCalculateHash.Margin = new Padding(4, 5, 4, 5);
			btnCalculateHash.Name = "btnCalculateHash";
			btnCalculateHash.Size = new Size(200, 46);
			btnCalculateHash.TabIndex = 5;
			btnCalculateHash.Text = "Вычислить хеш";
			btnCalculateHash.UseVisualStyleBackColor = true;
			btnCalculateHash.Click += btnCalculateHash_Click;
			// 
			// lblHash
			// 
			lblHash.AutoSize = true;
			lblHash.Location = new Point(26, 304);
			lblHash.Margin = new Padding(4, 0, 4, 0);
			lblHash.Name = "lblHash";
			lblHash.Size = new Size(117, 20);
			lblHash.TabIndex = 4;
			lblHash.Text = "Результат хеша:";
			// 
			// txtHashResult
			// 
			txtHashResult.Location = new Point(173, 300);
			txtHashResult.Margin = new Padding(4, 5, 4, 5);
			txtHashResult.Multiline = true;
			txtHashResult.Name = "txtHashResult";
			txtHashResult.ReadOnly = true;
			txtHashResult.ScrollBars = ScrollBars.Vertical;
			txtHashResult.Size = new Size(505, 121);
			txtHashResult.TabIndex = 3;
			// 
			// btnCopyHash
			// 
			btnCopyHash.Location = new Point(173, 443);
			btnCopyHash.Margin = new Padding(4, 5, 4, 5);
			btnCopyHash.Name = "btnCopyHash";
			btnCopyHash.Size = new Size(160, 46);
			btnCopyHash.TabIndex = 2;
			btnCopyHash.Text = "Копировать хеш";
			btnCopyHash.UseVisualStyleBackColor = true;
			btnCopyHash.Click += btnCopyHash_Click;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(346, 443);
			btnClear.Margin = new Padding(4, 5, 4, 5);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(160, 46);
			btnClear.TabIndex = 1;
			btnClear.Text = "Очистить";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// lblFileInfo
			// 
			lblFileInfo.AutoSize = true;
			lblFileInfo.Location = new Point(173, 189);
			lblFileInfo.Margin = new Padding(4, 0, 4, 0);
			lblFileInfo.Name = "lblFileInfo";
			lblFileInfo.Size = new Size(120, 20);
			lblFileInfo.TabIndex = 0;
			lblFileInfo.Text = "Размер файла: -";
			// 
			// button1
			// 
			button1.Location = new Point(26, 14);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(347, 46);
			button1.TabIndex = 11;
			button1.Text = "Данные о варианте";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(518, 443);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(160, 46);
			button2.TabIndex = 12;
			button2.Text = "Сохранить в файл";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(733, 530);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(lblFileInfo);
			Controls.Add(btnClear);
			Controls.Add(btnCopyHash);
			Controls.Add(txtHashResult);
			Controls.Add(lblHash);
			Controls.Add(btnCalculateHash);
			Controls.Add(btnSelectFile);
			Controls.Add(txtFilePath);
			Controls.Add(lblFile);
			Controls.Add(comboBoxVersion);
			Controls.Add(lblVersion);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(4, 5, 4, 5);
			MaximizeBox = false;
			Name = "MainForm";
			Text = "GOST Hash Calculator";
			Load += MainForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		private Label lblVersion;
		private ComboBox comboBoxVersion;
		private Label lblFile;
		private TextBox txtFilePath;
		private Button btnSelectFile;
		private Button btnCalculateHash;
		private Label lblHash;
		private TextBox txtHashResult;
		private Button btnCopyHash;
		private Button btnClear;
		private Label lblFileInfo;
		private Button button1;
		private Button button2;
	}
}