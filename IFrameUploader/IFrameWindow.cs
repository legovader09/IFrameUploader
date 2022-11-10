using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using IFrameUploader.Helpers;
using IFrameUploader.Models;
using IFrameUploader.Properties;
using MetroFramework.Forms;
using Newtonsoft.Json;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace IFrameUploader
{
    // ReSharper disable once InconsistentNaming
    public partial class IFrameWindow : MetroForm
    {
        private FileObject _fileObject;
        private AzureManager _azureCredManager;
        public IFrameWindow()
        {
            InitializeComponent();
        }

        private void Initialize(object sender, EventArgs e)
        {
            try
            {
                var importFile = Path.Combine(Directory.GetCurrentDirectory(), "import.json");
                if (File.Exists(importFile))
                {
                    ImportSettings(importFile);
                    File.Delete(importFile);
                }
                else
                {
                    SetDataSource();
                }
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception);
                throw;
            }
            txtAzurePath.Text = Settings.Default.AzurePath;
        }

        internal void SetDataSource()
        {
            try
            {
                var connStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(Settings.Default.ConnStrings);
                if (connStrings is {Count: 0}) return;
                comboBlobEnvs.DataSource = new BindingSource(connStrings, null);

                comboBlobEnvs.DisplayMember = "Key";
                comboBlobEnvs.ValueMember = "Value";
                _azureCredManager = new AzureManager(comboBlobEnvs.SelectedValue.ToString(),
                    $@"{txtAzurePath.Text}/{txtAzureFolder.Text}");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                Settings.Default.ConnStrings = "";
                throw;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadFolder();
        }

        private async Task UploadFolder()
        {
            if (!ValidationHelper.ValidatePath(_fileObject)) return;
            Enabled = false;
            pnlStatus.Visible = true;
            lblStatus.Text = @"Uploading...";
            await AzureHelper.UploadFolderAsync(_azureCredManager, _fileObject.Files, chkOpenWebsite.Checked, progressSpinner);
            lblStatus.Text = @"Upload Complete!";
            Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAzurePath.Text = @"$web";
            txtAzureFolder.Text = @"<folder>";
            _azureCredManager.Path = $@"{txtAzurePath.Text}/{txtAzureFolder.Text}";
            Settings.Default.AzurePath = _azureCredManager.Path;
            Settings.Default.Save();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            _fileObject = GetAllFilesInFolder();
            if (_fileObject == null) return;
            lblFilesFound.Text = $@"Found {_fileObject.Files.Length} files.";
            lblFilesFound.Visible = true;
            txtBuildFolderPath.Text = _fileObject.FilePath;
        }

        internal void ImportSettings(string importFile = "")
        {
            var fileName = importFile;
            if (importFile == "")
            {
                using var dialog = new OpenFileDialog { Filter = @"JSON Files (*.json)|*.json|All files (*.*)|*.*" };
                if (dialog.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(dialog.FileName)) return;
                fileName = dialog.FileName;
            }

            try
            {
                var file = File.ReadAllText(fileName);
                JsonConvert.DeserializeObject<Dictionary<string, string>>(file); //reads json and fails if not valid
                Settings.Default.ConnStrings = file;
                Settings.Default.Save();
                SetDataSource();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static FileObject GetAllFilesInFolder()
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(dialog.SelectedPath)) return null;

            var files = Directory.GetFiles(dialog.SelectedPath, "*.*", SearchOption.AllDirectories);
            return new FileObject(dialog.SelectedPath, files);
        }

        private void UpdateAzurePath(object sender, EventArgs e)
        {
            _azureCredManager.Path = $@"{txtAzurePath.Text}/{txtAzureFolder.Text}";
            Settings.Default.AzurePath = txtAzurePath.Text;
            Settings.Default.Save();
        }

        private void comboBlobEnvs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            _azureCredManager.ConnectionString = box.SelectedValue.ToString();
        }
    }
}
