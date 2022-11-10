namespace IFrameUploader.Models
{
    public class FileObject
    {
        public string FilePath { get; set; }
        public string[] Files { get; set; }
        public FileObject(string filePath, string[] files)
        {
            FilePath = filePath;
            Files = files;
        }
    }
}
