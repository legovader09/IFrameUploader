using System;
using System.IO;
using System.Windows.Forms;
using IFrameUploader.Models;

namespace IFrameUploader.Helpers
{
    internal class ValidationHelper
    {
        public static bool ValidatePath(FileObject file)
        {
            if (file == null) return false;
            try
            {
                if (!Directory.Exists(file.FilePath))
                {
                    MessageBox.Show(@"Please enter a valid path name.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (file.Files.Length == 0)
                {
                    MessageBox.Show(@"The selected directory is empty.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return false;
            }
        }
    }
}