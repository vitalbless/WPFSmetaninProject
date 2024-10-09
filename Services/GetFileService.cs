using Microsoft.Win32;
using System;
using System.IO;

namespace WPFSmetaninProject.Services
{
    class GetFileService
    {
        static string sourceImagePath = null;
        static string targetImagePath = null;
        static readonly string dirName = AppDomain.CurrentDomain.BaseDirectory + "Images\\";
        static readonly DirectoryInfo directoryInfo = new DirectoryInfo(dirName);
        static bool allowCopy = false;

        public static string GetImagePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл изображения|*.jpg;*.png;*.gif;*.tif;...";
           sourceImagePath = (openFileDialog.ShowDialog() == true) ? openFileDialog.FileName : null;

            if (sourceImagePath != null)
            {
                targetImagePath = $"{dirName}{Path.GetFileName(sourceImagePath)}";
                allowCopy = true;
                return targetImagePath;
            }
            else
            {
                allowCopy = false;
                return null;
            }
        }
        public static void CopyImageToProject()
        {
            if (allowCopy)
            {
                if (!directoryInfo.Exists)
                    directoryInfo.Create();

                File.Copy(sourceImagePath, targetImagePath);
            }
        }
    }
}
