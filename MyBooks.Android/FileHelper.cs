using System;
using Xamarin.Forms;
using MyBooks.Droid;
using System.IO;

[assembly: Dependency(typeof(FileHelper))]
namespace MyBooks.Droid
{
    public class FileHelper: IFileHelper
    {
        public FileHelper()
        {
        }

        public String GetLocalFilePath(String FileName) {
            String path = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, FileName);
        }
    }
}
