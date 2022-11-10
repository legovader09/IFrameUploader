using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IFrameUploader.Properties;
using Newtonsoft.Json;

namespace IFrameUploader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var obj = JsonConvert.DeserializeObject<Dictionary<string, string>>(Settings.Default.ConnStrings);
            settingsGrid.Columns.Add("Name", "Name");
            settingsGrid.Columns.Add("Connection String", "Connection String");
            if (obj == null) return;
            foreach (var (key, value) in obj) settingsGrid.Rows.Add(key, value);
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dict = new Dictionary<string, string>();
            foreach (DataGridViewRow row in settingsGrid.Rows)
            {
                var a = row.Cells[0].Value;
                var b = row.Cells[1].Value;
                if (a != null && b != null) dict.Add((string) a, (string) b);
            }
            Settings.Default.ConnStrings = JsonConvert.SerializeObject(dict);
            Settings.Default.Save();
        }
        private void CloseDialog(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void GridKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewCell cell in settingsGrid.SelectedCells)
                {
                    try
                    {
                        if (cell.Selected && !settingsGrid.Rows[cell.RowIndex].IsNewRow) 
                            settingsGrid.Rows.RemoveAt(cell.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        throw;
                    }
                }
            }
                
        }
    }
}
