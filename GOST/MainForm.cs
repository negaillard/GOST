namespace GOST
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			comboBoxVersion.SelectedIndex = 0; // Выбираем 256 по умолчанию
		}

		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Выберите файл для хеширования";
				openFileDialog.Filter = "Все файлы (*.*)|*.*";
				openFileDialog.Multiselect = false;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					txtFilePath.Text = openFileDialog.FileName;
				}
			}
		}

		private void btnCalculateHash_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtFilePath.Text))
			{
				MessageBox.Show("Пожалуйста, выберите файл.", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!File.Exists(txtFilePath.Text))
			{
				MessageBox.Show("Выбранный файл не существует.", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				Cursor = Cursors.WaitCursor;
				btnCalculateHash.Enabled = false;

				bool version = comboBoxVersion.SelectedIndex == 0 ? false : true;

				byte[] fileBytes = File.ReadAllBytes(txtFilePath.Text);

				GhostHash ghost = new GhostHash();
				byte[] hash = ghost.GetHash(fileBytes, version);

				string hashString = BitConverter.ToString(hash).Replace("-", "").ToLower();

				txtHashResult.Text = hashString;

				ShowFileInfo(fileBytes.Length);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при вычислении хеша: {ex.Message}", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Cursor = Cursors.Default;
				btnCalculateHash.Enabled = true;
			}
		}

		private void ShowFileInfo(long fileSize)
		{
			lblFileInfo.Text = $"Размер файла: {fileSize} байт ({FormatFileSize(fileSize)})";
		}

		private string FormatFileSize(long bytes)
		{
			string[] sizes = { "B", "KB", "MB", "GB" };
			int order = 0;
			double len = bytes;
			while (len >= 1024 && order < sizes.Length - 1)
			{
				order++;
				len = len / 1024;
			}
			return $"{len:0.##} {sizes[order]}";
		}

		private void btnCopyHash_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtHashResult.Text))
			{
				Clipboard.SetText(txtHashResult.Text);
				MessageBox.Show("Хеш скопирован в буфер обмена.", "Успех",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtHashResult.Clear();
			lblFileInfo.Text = "Размер файла: -";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var readmeForm = new ReadmeForm();
			readmeForm.FormClosed += (s, ea) => this.Show();
			readmeForm.Show();
			this.Hide();
		}

		public void SaveHashToFile(string hashString, string filePath)
		{
			File.WriteAllText(filePath, hashString);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtHashResult.Text))
			{
				MessageBox.Show("Нет хеша для сохранения.", "Информация",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
				saveFileDialog.FileName = $"hash_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						File.WriteAllText(saveFileDialog.FileName, txtHashResult.Text);

						MessageBox.Show($"Хеш сохранен в файл:\n{saveFileDialog.FileName}",
							"Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}


	}
}
