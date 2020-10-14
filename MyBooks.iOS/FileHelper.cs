using System;
using Xamarin.Forms;
using MyBooks.iOS;
using System.IO;

[assembly: Dependency(typeof(FileHelper))]
namespace MyBooks.iOS
{
    public class FileHelper: IFileHelper
    {
        public FileHelper()
        {
        }

        public String GetLocalFilePath(String FileName)
        {
            String docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder)) {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, FileName);
        }
    }
}
