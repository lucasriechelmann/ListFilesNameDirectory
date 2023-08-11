using Newtonsoft.Json;
using System.Diagnostics;

namespace ListFilesNameDirectory
{
    public partial class frmMain : Form
    {
        string AppPath = Application.StartupPath;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFolderFiles.Text = folderBrowserDialog.SelectedPath.Trim('\\').Trim('/');
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var fileName = "extensions.json";
            var relativePath = $"Config\\{fileName}";
            var filePath = $"{AppPath}\\{relativePath}";

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var extensions = JsonConvert.DeserializeObject<List<string>>(json);
                foreach (var extension in extensions)
                {
                    clbFilesToList.Items.Add(extension);
                }

                Check(true);
                return;
            }

            var extensionsDef = new string[] { "jpg", "jpeg", "png", "doc", "docx", "pdf", "xls", "xlsx" };

            foreach (var extension in extensionsDef)
            {
                clbFilesToList.Items.Add(extension);
            }

            Check(true);
        }

        private void btnCheckAll_Click(object sender, EventArgs e) => Check(true);
        private void btnUncheckAll_Click(object sender, EventArgs e) => Check(false);
        void Check(bool check) => clbFilesToList
            .Items
            .Cast<string>()
            .ToList()
            .ForEach(item => clbFilesToList.SetItemChecked(clbFilesToList.Items.IndexOf(item), check));

        private void btnList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolderFiles.Text))
            {
                MessageBox.Show("Select a folder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var listOfFiles = clbFilesToList.CheckedItems.Cast<string>().ToList();
            var folderModel = GetFiles(txtFolderFiles.Text, listOfFiles);

            var json = JsonConvert.SerializeObject(folderModel, Formatting.Indented);
            var uniqueName = $"{Guid.NewGuid().ToString().Replace("-", "")}.json";
            var outputFolder = $"{AppPath}Output";
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            File.WriteAllText($"{outputFolder}\\{uniqueName}", json);
            MessageBox.Show($"Done file on {outputFolder}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("explorer.exe", outputFolder);
        }
        FolderModel GetFiles(string folder, List<string> listOfFiles)
        {
            FolderModel folderModel = new FolderModel()
            {
                Folder = folder.Trim('\\').Trim('/') == txtFolderFiles.Text.Trim('\\').Trim('/') ? "" : Path.GetFileName(folder)
            };

            var files = Directory.GetFiles(folder, "*.*", SearchOption.TopDirectoryOnly)
                .Where(file => listOfFiles.Any(item => file.EndsWith(item)));

            folderModel.Files = files.Select(file => new FileModel
            {
                FileName = Path.GetFileNameWithoutExtension(file),
                Extension = Path.GetExtension(file).Replace(".", "")
            }).ToList();

            if (cnIncludeSubFolders.Checked)
            {
                var folders = Directory.GetDirectories(folder, "*.*", SearchOption.TopDirectoryOnly);
                folderModel.Folders = folders.Select(f => GetFiles(f, listOfFiles)).ToList();
            }

            return folderModel;
        }
    }
    public class FolderModel
    {
        public string Folder { get; set; }
        public List<FolderModel> Folders { get; set; }
        public List<FileModel> Files { get; set; } 
    }
    public class FileModel
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
    }
}