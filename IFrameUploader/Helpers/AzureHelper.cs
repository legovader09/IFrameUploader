using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using HeyRed.Mime;
using IFrameUploader.Models;
using MetroFramework.Controls;

namespace IFrameUploader.Helpers
{
    public class AzureHelper
    {
        public static async Task UploadFolderAsync(AzureManager manager, string[] paths, bool openAfterComplete, MetroProgressSpinner spinner)
        {
            try
            {
                var uri = "";
                spinner.Maximum = paths.Length;
                foreach (var path in paths)
                {
                    var x = File.OpenRead(path);
                    var dir = new DirectoryInfo(Path.GetDirectoryName(path) ?? throw new Exception()).Name;
                    var fileName = Path.GetFileName(path);
                    var container = new BlobClient(manager.ConnectionString, $"{manager.Path}{(fileName.Contains("html") ? "" : $"/{dir}")}", fileName);
                    spinner.Value++;
                    await container.UploadAsync(x, new BlobHttpHeaders { ContentType = MimeTypesMap.GetMimeType(fileName) });
                    if (openAfterComplete && string.IsNullOrEmpty(uri))
                        uri = container.Uri.AbsoluteUri.Replace("blob", "z33.web").Replace("/$web", "");
                }
                if (!openAfterComplete) return;
                var ps = new ProcessStartInfo(uri)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}